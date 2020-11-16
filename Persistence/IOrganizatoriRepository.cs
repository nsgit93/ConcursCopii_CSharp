using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IOrganizatoriRepository : IRepository<int, Organizator>
    {
        Organizator FindOneByUserName(string userName);
    }
}
