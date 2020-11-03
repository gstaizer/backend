using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveExtraBlanksLibrary;

namespace RemoveExtraBlanks
{
    class Program
    {
        static void Main(string[] args)
        {
            const string incorrectNumber = "Incorrect number of arguments!", example = "Usage RemoveExtraBlanks.exe <inputFile> <outputFile>";

            if (args.Length != 2)
            {
                Console.WriteLine(incorrectNumber);
                Console.WriteLine(example);
                return;
            }

            string inputFile = args[0];
            string outputFile = args[1];

            StringProcessor stringProcessor = new StringProcessor();
            using (StreamReader readerStream = new StreamReader(inputFile))
            using (StreamWriter writerStream = new StreamWriter(outputFile))
            {
                while (!readerStream.EndOfStream)
                {
                    string line = readerStream.ReadLine();
                    line = stringProcessor.RemoveExtraBlanks(line);
                    writerStream.WriteLine(line);
                }
            }
        }
    }
}