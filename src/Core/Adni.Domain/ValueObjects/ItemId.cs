using System;
using System.Collections.Generic;

namespace Adni.Domain.ValueObjects
{
    public class ItemId : IEquatable<ItemId>
    {
        private readonly Guid _value;

        public ItemId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value),"L'element suivant ne peut avoir d'identifiant nul");
            _value = value;
        }

        public bool Equals(ItemId other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value.Equals(other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals (obj, null)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (ItemId)) return false;
            return base.Equals((ItemId) obj);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public static bool operator ==(ItemId left, ItemId right) => Equals(left, right);

        public static bool operator !=(ItemId? left, ItemId? right) => !Equals(left, right);
    }
}