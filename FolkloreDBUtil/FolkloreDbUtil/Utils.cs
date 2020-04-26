using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FolkloreOutaouais.Adhesions
{
    internal static class Utils
    {
        internal static int DaysInNextYear(DateTime from)
        {
            int daysToAdd = 365;
            if (from.Month >= 3 && DateTime.IsLeapYear(from.Year + 1)) {
                daysToAdd = 366;
            }
            if (from.Month < 3 && DateTime.IsLeapYear(from.Year)) {
                daysToAdd = 366;
            }
            return daysToAdd;
        }
        internal static string ConcatanateListOfString(List<string> list)
        {
            string retString = string.Empty;
            foreach (string s in list) {
                retString += s;
            }
            return retString.Substring(0, retString.Length - 2);
        }
        internal static bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            } catch {
                return false;
            }
        }
        internal static bool IsCodePostalValide(string codePostal)
        {
            if (codePostal[3] != ' ') {
                return false;
            }
            return Regex.IsMatch(codePostal, "\\A[ABCEGHJKLMNPRSTVXY]\\d[A-Z] ?\\d[A-Z]\\d\\z");
        }
    }
}
