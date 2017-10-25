using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Tourspider.Ticketmaster.Sdk.Extensions
{
    public static class EnumExtensions
    {
        public static string GetValue(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<EnumMemberAttribute>()
                .Value;
        }
    }
}
