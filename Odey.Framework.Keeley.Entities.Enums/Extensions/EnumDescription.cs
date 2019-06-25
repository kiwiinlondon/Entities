using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace Odey.Framework.Keeley.Entities.Enums.Extensions
{
    public static class EnumDescription
    {
        private static ConcurrentDictionary<object, int> _descriptions = new ConcurrentDictionary<object, int>();

        public static int GetDescription(this Enum value)
        {
            return _descriptions.GetOrAdd(value, CreateDescriptionValue);
        }

        private static string CreateDescriptionValue(object value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
