using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookWebApi.Models
{
    public class Validation
    {
        public static bool IsPositiveNumber(int id)
        {
            return id > 0;
        }

        public static bool IsContainsLettersOnly(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }
    }
}
