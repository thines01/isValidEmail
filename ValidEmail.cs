using System.Text.RegularExpressions;

namespace ValidEmail
{
   public class CValidEmail
   {
      public static bool isValidEmail(string strEmailAddress)
      {
         string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

         return (new Regex(strRegex)).IsMatch(strEmailAddress);
      }
   }
}
