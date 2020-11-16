using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public interface IService
    {
        void Login(Organizator organizator, IObserver client);
        void Logout(Organizator organizator, IObserver client);
        List<Participant> GetParticipanti();
        List<Participare> GetParticipari();
        List<Participant> GetParticipantiByProba(string proba);
        List<Participant> GetParticipantiByVarsta(string varsta);
        List<Participant> GetParticipantiByProba_Varsta(string proba, string varsta);
        void AdaugaParticipant(Participant participant);
        void AdaugaParticipare(Participant participant, String proba);
        int NumarParticipariProba(string proba);

    }
}
