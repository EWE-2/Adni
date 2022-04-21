using System;
using System.Collections.Generic;

namespace Adni.Domain.ValueObjects
{
    public class ItemId : ItemIdBase
    {
        public ItemId(Guid value) => _value = value;

    }
}