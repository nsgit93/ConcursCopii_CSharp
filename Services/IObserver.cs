using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public interface IObserver
    {
        void participantAdaugat(Participant participant);
        void participareAdaugata(Participare participare, Participant updatedParticipant, int nrComoara, int nrDesen, int nrPoezie);
    }
}
