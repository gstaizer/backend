using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckIdentifierLibrary;

namespace CheckIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            const string incorrectNumber = "Incorrect number of arguments!", example = "Usage CheckIdentifier.exe <identifier>", emptyInput = "Input is empty",
                incorrectIndexStr = "incorrect Index ", incorrectCharStr = ", incorrect Char ";

            if (args.Length != 1)
            {
                Console.WriteLine(incorrectNumber);
                Console.WriteLine(example);
                return;
            }

            CheckIdentifierLibrary.CheckIdentifier checkIdentifier = new CheckIdentifierLibrary.CheckIdentifier();
            string identifier = args[0];
            if (checkIdentifier.IsIdentifier(identifier))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
                if (checkIdentifier.IsEmpty())
                {
                    Console.WriteLine(emptyInput);
                }
                else
                {
                    int incorrectIndex = checkIdentifier.GetIncorrectIndex();
                    Console.WriteLine(incorrectIndexStr + incorrectIndex + incorrectCharStr + "'" + identifier[incorrectIndex] + "'");
                }
            }
        }
    }
}
