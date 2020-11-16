using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Participant: Entity<int>
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public int NumarParticipari { get; set; }

        public Participant(int id, string nume, int varsta, int nr) : base(id)
        {
            Nume = nume;
            Varsta = varsta;
            NumarParticipari = nr;
        }

        public override string ToString()
        {
            return base.ToString() + Nume + " Varsta: " + Varsta + " Participari: " + NumarParticipari;
        }
    }
}
