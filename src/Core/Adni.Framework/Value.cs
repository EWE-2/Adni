using System;

namespace Adni.Framework
{
    public abstract class Value<T> where T: IEquatable<T>
    {
        public string _Value { get;}

        public Value(string value) => _Value = value;
        public bool Equals(Value<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _Value.Equals(other._Value);
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals (this, obj)) return true;
            if(obj.GetType() != typeof(Value<T>)) return false;
            return Equals((Value<T>) obj);
        }

        public override int GetHashCode() => _Value.GetHashCode();

        public static bool operator ==(Value<T> left, Value<T> right) => Equals(left, right);

        public static bool operator !=(Value<T> left, Value<T> right) => !Equals(left, right);
    }
}
