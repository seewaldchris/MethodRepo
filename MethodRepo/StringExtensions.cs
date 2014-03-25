using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodRepo.Extensions
{
    public static class StringExtensions
    {
        public static string TrimManagedMetadata(this string s)
        {
            if (s.Contains("|"))
                return s.Substring(0, s.IndexOf('|'));
            else
                return s;
        }
    }
}
