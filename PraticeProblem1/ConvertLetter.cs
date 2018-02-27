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
            string exception2 = "Only one letter can be inputted";

            if(!Regex.IsMatch(letter, @"^[a-zA-Z]+$")) 
            {
                return exception;
            }
            else if(letter.Length > 1)
            {
                return exception2;
            }
            else
            {
                return letter.ToUpper();
            }
            
        }

    }
}
