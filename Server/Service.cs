using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Persistence;
using Domain.Validator;
using Services;

namespace Server
{
    class Service : MarshalByRefObject, IService
    {
        private IOrganizatoriRepository RepoOrganizatori;
        private IParticipantiRepository RepoParticipanti;
        private IParticipariRepository RepoParticipari;
        private IValidator<Participant> Validator;
        private readonly IDictionary<String, IObserver> loggedClients;


        public Service(IOrganizatoriRepository RepoOrganizatori, 
            IParticipantiRepository RepoParticipanti, IParticipariRepository RepoParticipari, IValidator<Participant> validator)
        {
            this.RepoOrganizatori = RepoOrganizatori;
            this.RepoParticipanti = RepoParticipanti;
            this.RepoParticipari = RepoParticipari;
            this.Validator = validator;
            this.loggedClients = new Dictionary<string, IObserver>();
        }

        public void Login(Organizator organizator, IObserver client)
        {
            Organizator organizatorOk = RepoOrganizatori.FindOneByUserName(organizator.UserName);
            if (organizatorOk != null)
            {
                if (loggedClients.ContainsKey(organizatorOk.ID.ToString()))
                    throw new ServiceException("User already logged in.");
                else if (organizator.Parola.Equals(organizatorOk.Parola))
                    loggedClients[organizatorOk.ID.ToString()] = client;
            }
            else
                throw new ServiceException("Authentication failed.");
        }

        public void Logout(Organizator organizator, IObserver client)
        {
            Organizator organizatorOk = RepoOrganizatori.FindOneByUserName(organizator.UserName);
            IObserver localClient = loggedClients[organizatorOk.ID.ToString()];
            if (localClient == null)
                throw new ServiceException("User"+ organizatorOk.ID +"not logged in!");
            loggedClients.Remove(organizatorOk.ID.ToString());

        }

        public List<Participant> GetParticipanti()
        {
            return this.RepoParticipanti.FindAll();
        }

        public List<Participare> GetParticipari()
        {
            return this.RepoParticipari.FindAll();
        }

        public List<Participant> GetParticipantiByProba(string proba)
        {
            return this.RepoParticipanti.FindParticipantiByProba(proba);
        }

        public List<Participant> GetParticipantiByVarsta(string varsta)
        {
            return this.RepoParticipanti.FindParticipantiByVarsta(varsta);
        }

        public List<Participant> GetParticipantiByProba_Varsta(string proba, string varsta)
        {
            return this.RepoParticipanti.FindParticipantiByProba_Varsta(proba,varsta);
        }

        public void AdaugaParticipant(Participant participant)
        {
            try
            {
                this.Validator.Validate(participant);
                this.RepoParticipanti.Save(participant);
                notifyParticipantAdaugat(RepoParticipanti.FindLastAdded());
            }
            catch (ValidationException ve)
            {
                throw new ServiceException(ve.Message);
            }
        }

        public void AdaugaParticipare(Participant participant, String proba)
        {
            int varsta = participant.Varsta;
            String categorieVarsta = "";
            if (participant.NumarParticipari < 2)
            {
                if (varsta >= 6 && varsta <= 8)
                    categorieVarsta = "6-8";
                else if (varsta >= 9 && varsta <= 11)
                    categorieVarsta = "9-11";
                else if (varsta >= 12 && varsta <= 15)
                    categorieVarsta = "12-15";
                Participare participare = new Participare(0, participant.ID, proba, categorieVarsta);
                try
                {
                    RepoParticipari.Save(participare);
                    int nrParticipari = participant.NumarParticipari + 1;
                    Participant updated = new Participant(participant.ID, participant.Nume, participant.Varsta, nrParticipari);
                    RepoParticipanti.Update(updated);
                    notifyParticipareAdaugata(RepoParticipari.FindLastAdded(), updated);
                }
                catch (RepositoryException re)
                {
                    throw new ServiceException(re.Message);
                }
            }
            else
            {
                throw new ServiceException("Participantul cu id-ul " + participant.ID + " are deja 2 participari!");
            }

        }



        private void notifyParticipantAdaugat(Participant participant)
        {
            IEnumerable<Organizator> organizatori = RepoOrganizatori.FindAll();
            foreach (Organizator organizator in organizatori)
            {
                if (loggedClients.ContainsKey(organizator.ID.ToString()))
                {
                    IObserver client = loggedClients[organizator.ID.ToString()];
                    Task.Run(() => client.participantAdaugat(participant));
                }
            }
        }

        private void notifyParticipareAdaugata(Participare participareAdaugata, Participant participantActualizat)
        {
            IEnumerable<Organizator> organizatori = RepoOrganizatori.FindAll();
            foreach (Organizator organizator in organizatori)
            {
                if (loggedClients.ContainsKey(organizator.ID.ToString()))
                {
                    IObserver client = loggedClients[organizator.ID.ToString()];
                    Task.Run(() => client.participareAdaugata(participareAdaugata,participantActualizat,
                        RepoParticipari.NrParticipariProba("Cautare comoara"),RepoParticipari.NrParticipariProba("Desen"),
                        RepoParticipari.NrParticipariProba("Poezie")));
                }
            }
        }

        public int NumarParticipariProba(string proba)
        {
            return RepoParticipari.NrParticipariProba(proba);
        }


        public override object InitializeLifetimeService()
        {
            return null;
        }

    }

}
