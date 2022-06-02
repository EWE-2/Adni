using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;
using Adni.Domain.Interfaces.Date_Time;

namespace Adni.Domain.Entities
{
    public class IntershipSession
    {
        public Guid InternSessionId { get; set; }

        public ActorId StartingActorId; //Employee ayant lance la nouvelle session de stage
        public DateTime StartingDate;
        public DateTime _endingDate;

        // Creation d'une session annuelle de stage
    }
}
