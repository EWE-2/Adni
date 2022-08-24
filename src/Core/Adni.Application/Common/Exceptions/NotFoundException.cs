using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base()
        { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public NotFoundException(string name, object key) : base($"L'element \"{ name }\" ({key}) n'a pas été trouvé.") { }
    }
}
