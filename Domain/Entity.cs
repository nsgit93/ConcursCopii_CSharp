using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Entity<TID>
    {
        public TID ID { get; set; }

        public Entity()
        {

        }
        public Entity(TID id)
        {
            ID = id;
        }

        public override string ToString()
        {
            return ID.ToString() + " ";
        }
    }
}
