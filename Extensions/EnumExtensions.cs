using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EditClicker.Extensions
{
    static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            string valueAsString = value.ToString();
            FieldInfo info = value.GetType().GetField(valueAsString);

            if (info.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
                return attributes.First().Description;

            return valueAsString;
        }
    }
}
