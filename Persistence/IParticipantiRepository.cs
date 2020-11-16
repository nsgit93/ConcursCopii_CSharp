using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IParticipantiRepository : IRepository<int, Participant>
    {
        List<Participant> FindParticipantiByProba(string proba);
        List<Participant> FindParticipantiByVarsta(string categorieVarsta);
        List<Participant> FindParticipantiByProba_Varsta(string proba, string categorieVarsta);
        Participant FindLastAdded();
    }
}
