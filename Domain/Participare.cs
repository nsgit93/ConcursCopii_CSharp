using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Participare: Entity<int>
    {
        public int IdParticipant { get; set; }
        public string Proba { get; set; }
        public string CategorieVarsta { get; set; }


        public Participare(int id, int idpart, string proba, string categ) : base(id)
        {
            IdParticipant = idpart;
            Proba = proba;
            CategorieVarsta = categ;
        }
    }
}
