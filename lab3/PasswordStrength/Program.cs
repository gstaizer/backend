using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordStrengthLibrary;

namespace PasswordStrength
{
    class Program
    {
        const string incorrectNumber = "Incorrect number of arguments!", example = "Usage PasswordStrength.exe <password>";

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(incorrectNumber);
                Console.WriteLine(example);
                return;
            }
            PasswordStrengthLibrary.PasswordStrength passwordStrength = new PasswordStrengthLibrary.PasswordStrength();
            Console.WriteLine(passwordStrength.CalcSafety(args[0]));
        }
    }
}
