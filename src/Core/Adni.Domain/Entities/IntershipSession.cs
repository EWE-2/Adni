using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    internal class IntershipSession
    {
        public Guid Id { get; private set; }
        private ActorId _startingActorId;

        private DateTime _startingDate;
        private DateTime _endingDate;

        public IntershipSession(Guid id, ActorId suId)
        {
            if (id == default)
                throw new ArgumentNullException("Erreur !!! L'identifiant n'a pas ete fourni correctement", nameof(id));

            Id = id;
            _startingActorId = suId;
        }
    }
}
