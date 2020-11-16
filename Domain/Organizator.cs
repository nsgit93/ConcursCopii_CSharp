using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Organizator: Entity<int>
    {
        public string Nume { get; set; }
        public string UserName { get; set; }
        public string Parola { get; set; }

        public Organizator()
        {

        }

        public Organizator(string username, string parola)
        {
            this.UserName = username;
            this.Parola = parola;
        }

        public Organizator(int id, string nume, string user, string parola) :
            base(id)
        {
            Nume = nume;
            UserName = user;
            Parola = parola;
        }

        public override string ToString()
        {
            return base.ToString() + " " + UserName + " " + Nume + " ";
        }
    }
}
