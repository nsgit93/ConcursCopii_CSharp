using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ParticipareAdaugataInfo
    {
        public Participant participant { get; set; }
        public Participare participare { get; set; }
        public int nrComoara { get; set; }
        public int nrDesen { get; set; }
        public int nrPoezie { get; set; }

        public ParticipareAdaugataInfo(Participare participare, Participant participant, int nrComoara, int nrDesen, int nrPoezie)
        {
            this.participant = participant;
            this.participare = participare;
            this.nrComoara = nrComoara;
            this.nrDesen = nrDesen;
            this.nrPoezie = nrPoezie;
        }

    }
}
