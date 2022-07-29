using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexWithTesting
{
    public class RegexNameValidation
    {
        const string NAME = "^[A-Z]{1}[a-z]{2,}$";

        public bool FirstNameValidation(string FirstName)
        {
            var logger =NLog.LogManager.GetCurrentClassLogger();
            logger.Info("App Started {arguments}", logger.Name, FirstName);
            if (Regex.IsMatch(FirstName, NAME))
            {
                Console.WriteLine("First name is valid. ");
                return true;
            }
            Console.WriteLine("First name is not valid");
            return false;
        }
        public bool LastNameValidation(string LastName)
        {
            var logger =NLog.LogManager.GetCurrentClassLogger();
            logger.Info("Last Name", LastName, logger.Name, LastName);
            if (Regex.IsMatch(LastName, NAME))
            {
                Console.WriteLine("Last name is valid. ");
                return true;
            }
            Console.WriteLine("Last name is not valid");
            return false;
        }
        
    }
}
