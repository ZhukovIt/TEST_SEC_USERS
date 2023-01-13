using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SEC_USERS
{
    public static class Extensions
    {
        public static string JoinConditionsExtensions(this IEnumerable<string> items, string condition, string separator)
        {
            StringBuilder result = new StringBuilder();
            string lastElement = items.Last();
            foreach (string item in items)
            {
                result.Append(item);
                result.Append(condition);
                if (item != lastElement) result.Append(separator);
            }
            return result.ToString();
        }
    }
}
