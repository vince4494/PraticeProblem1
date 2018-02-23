using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PracticeProblem1
{
    public class ConvertLetter
    {

        public string upperCaseLetter(string letter)
        {
            string exception = "Input is not a letter";

            if(Regex.IsMatch(letter, @"^[a-zA-Z]+$"))
            {
                return letter.ToUpper();
            }
            else
            {
                return exception;
            }
            
        }

    }
}
