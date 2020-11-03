using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            const string incorrectNumber = "Incorrect number of arguments!", example = "Usage RemoveDuplicates.exe < input string>";

            if (args.Length != 1)
            {
                Console.WriteLine(incorrectNumber);
                Console.WriteLine(example);
                return;
            }

            string line = args[0];
            Dictionary<char, bool> exitingChars = new Dictionary<char, bool>();

            foreach (char ch in line)
            {
                if (!exitingChars.ContainsKey(ch))
                {
                    exitingChars[ch] = true;
                    Console.Write(ch);
                }
            }
        }
    }
}
