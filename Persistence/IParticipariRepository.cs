using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IParticipariRepository : IRepository<int, Participare>
    {
        int NrParticipariProba(string proba);
        Participare FindLastAdded();
    }
}
