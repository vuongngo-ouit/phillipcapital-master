using System;
using System.Collections.Generic;
using System.Text;

namespace PhillipCapital.Utilities
{
    /// <summary>
    /// Define the to string value for string enum
    /// </summary>
    public static class StringEnum
    {
        /// <summary>
        /// Gets the string value.
        /// </summary>
        /// <param name="thisEnum">The value.</param>
        /// <returns></returns>
        public static string ToValue(this Enum thisEnum)
        {
            string output = null;
            var type = thisEnum.GetType();
            //
            // Check first in our cached results...
            // Look for our 'StringValueAttribute' in the field's custom attributes
            var fi = type.GetField(thisEnum.ToString());
            var attrs = fi.GetCustomAttributes(typeof(StringValue), false) as StringValue[];
            if (attrs != null && attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }

        public static IEnumerable<T> EnumToList<T>()
        {
            var enumType = typeof(T);

            // Can't use generic type constraints on value types,
            // so have to do check like this
            if (enumType.BaseType != typeof(System.Enum))
            {
                throw new ArgumentException("T must be of type System.Enum");
            }

            var enumValArray = System.Enum.GetValues(enumType);
            var enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray)
            {
                enumValList.Add((T)System.Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Define the string value enumeration
    /// </summary>
    public class StringValue : Attribute
    {
        public StringValue(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; }
    }

    public enum BasKetPaymentMethod
    {
        [StringValue("Pay In")] PayIn,
        [StringValue("ATS")] ATS,
        [StringValue("Prepaid")] Prepaid,
        [StringValue("P Money")] PMoney,
    }
}
