using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Interfaces.Date_Time
{
    internal interface ISettingDateTime
    {
        /* remplacer le string par le type DateTime */
        public void SetDateTime(DateTime dt);
        public void UpdateDateTime(DateTime time);
    }
}
