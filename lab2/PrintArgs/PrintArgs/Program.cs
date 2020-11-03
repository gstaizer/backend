using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NoParametres = "No parameters were specified!", numberOfArg = "Number of arguments: {0}", arguments = "Arguments: {0}";

            if (args.Length == 0)
            {
                Console.WriteLine(NoParametres);
            }
            else
            {
                Console.WriteLine(numberOfArg, args.Length);
                Console.Write(arguments, String.Join(" ", args));
            }
        }
    }
}
