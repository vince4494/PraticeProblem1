using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            Console.WriteLine("Type in a Letter:");
            string input = Console.ReadLine();
            Console.WriteLine("Capitalized Letter:");
            ConvertLetter convertLetterFromUserInput = new ConvertLetter();
            output = convertLetterFromUserInput.upperCaseLetter(input);
            Console.WriteLine(output);

        }
    }
}
