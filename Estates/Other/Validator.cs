using System;

namespace Estates.Other
{
    public static class Validator
    {
        public static void Validation(object value, string type)
        {
            if(value is string)
            {
                string s = value.ToString();
                if (s == null || s == "")
                {
                    throw new ArgumentNullException("{0} cannot be null or empty.", type);
                }
            }
            if(value is decimal)
            {
                decimal d = (decimal)value;
                IsNegative(d, type);
            }
            if(value is int)
            {
                int i = (int)value;
                IsNegative(i, type);
            }
        }

        private static void IsNegative<T>(T value, string type) where T : IComparable<T>
        {
            if(value.CompareTo(default(T)) < 0)
            {
                throw new ArgumentOutOfRangeException("{0} cannot be negative.", type);
            }
        }
    }
}
