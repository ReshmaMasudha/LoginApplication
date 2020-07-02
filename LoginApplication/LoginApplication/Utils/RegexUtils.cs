using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace LoginApplication.Utils
{
    public static class RegexUtils
    {
        public static bool ValidPasswordLenth(string password)
        {
            return Regex.IsMatch(password, "^.{5,12}$");           
        }

        public static bool ValidCharachters(string password)
        {
            return Regex.IsMatch(password, "^(?=.*[a-zA-Z])(?=.*[0-9])");
        }

        //public static bool ValidSequenceChecker(string password, int sequenceLength)
        //{
        //    return Regex.IsMatch(password, "^([a-zA-Z0-9])\\1{" + (sequenceLength - 1) + "}");
        //}
    }
}
