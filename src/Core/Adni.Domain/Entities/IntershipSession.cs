using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;
using Adni.Domain.Interfaces.Date_Time;

namespace Adni.Domain.Entities
{
    internal class IntershipSession : IGettingDateTime
    {
        public Guid Id { get; private set; }

        private ActorId _startingActorId;
        private DateTime _startingDate;
        //private readonly DateTime _endingDate;


        //Recuperation de la date de creation de la Session
        public DateTime GetDateTime() => _startingDate = DateTime.Now;

        public IntershipSession(Guid id, ActorId suId)
        {
            if (id == default)
                throw new ArgumentNullException("Erreur !!! L'identifiant n'a pas ete fourni correctement", nameof(id));
            Id = id;
            _startingActorId = suId ?? throw new ArgumentNullException("L'utilisateur voulant creer la session doit etre specifie", nameof(suId)); //
            GetDateTime();
        }

        // Creation d'une session annuelle de stage
    }
}
