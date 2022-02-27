using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.ValueObjects
{
    internal class ActorId
    {
        private readonly Guid _value;

        public ActorId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "L'identifiant de l'utilisateur ne peux etre nul");
            _value = value;
        }
    }
}
