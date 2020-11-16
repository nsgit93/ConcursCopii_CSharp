using Domain;
using Services;
using System;
using System.Collections.Generic;


namespace Client
{
    public class Controller : MarshalByRefObject, IObserver

    {

        private readonly IService service;
        private Organizator organizator;
        public event EventHandler<ChatUserEventArgs> updateEvent;


        public Controller(IService service)
        {
            this.service = service;
            this.organizator = null;
        }

        public void participantAdaugat(Participant participant)
        {
            ChatUserEventArgs userArgs = new ChatUserEventArgs(ChatUserEvent.ParticipantAdaugat, participant);
            OnUserEvent(userArgs);
        }

        public void participareAdaugata(Participare participare, Participant updatedParticipant, int nrComoara, int nrDesen, int nrPoezie)
        {
            ParticipareAdaugataInfo updateInfo = new ParticipareAdaugataInfo(participare, updatedParticipant, nrComoara, nrDesen, nrPoezie);
            ChatUserEventArgs userArgs = new ChatUserEventArgs(ChatUserEvent.ParticipareAdaugata, updateInfo);
            OnUserEvent(userArgs);
        }


        protected virtual void OnUserEvent(ChatUserEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
            Console.WriteLine("Update Event called");
        }

        public void Login(string username, string password)
        {
            Organizator organizator = new Organizator(username, password);
            service.Login(organizator, this);
            this.organizator = organizator;
        }


        public void Logout()
        {
            service.Logout(organizator, this);
            organizator = null;
        }



        public List<Participant> GetParticipanti()
        {
            return service.GetParticipanti();
        }
        public List<Participare> GetParticipari()
        {
            return service.GetParticipari();
        }
        public List<Participant> GetParticipantiByProba(string proba)
        {
            return service.GetParticipantiByProba(proba);
        }
        public List<Participant> GetParticipantiByVarsta(string varsta)
        {
            return service.GetParticipantiByVarsta(varsta);
        }
        public List<Participant> GetParticipantiByProba_Varsta(string proba, string varsta)
        {
            return service.GetParticipantiByProba_Varsta(proba, varsta);
        }

        public void AdaugaParticipant(Participant participant)
        {

            service.AdaugaParticipant(participant);

        }


        public void AdaugaParticipare(Participant participant, String proba)
        {
            service.AdaugaParticipare(participant, proba);
        }


        public int NumarParticipariProba(string proba)
        {
            return service.NumarParticipariProba(proba);
        }




    }
}
