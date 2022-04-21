using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.ValueObjects
{
    internal class IntershipSessionId
    {
        private Guid _value;
        public IntershipSessionId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "L'identifiant de la session ne peut etre vide");
            _value = value;
        }
    }
}
