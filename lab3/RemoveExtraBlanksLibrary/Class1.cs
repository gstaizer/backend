using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveExtraBlanksLibrary
{
    enum Position
    {
        Tabulation,
        Other
    };

    public class StringProcessor
    {
        private bool isWhitespace(char ch)
        {
            return ch == '\t' || ch == ' ';
        }

        public string RemoveExtraBlanks(string input)
        {
            string cleared = input.Trim(new char[] { ' ', '\t' });
            string currLine = "";

            Position state = Position.Other;
            for (int i = 0; i < cleared.Length; i++)
            {
                char ch = cleared[i];
                Console.WriteLine(ch);
                switch (state)
                {
                    case Position.Other:
                        currLine += ch;
                        if (isWhitespace(ch))
                        {
                            state = Position.Tabulation;
                        }
                        break;
                    case Position.Tabulation:
                        if (!isWhitespace(ch))
                        {
                            currLine += ch;
                            state = Position.Other;
                        }
                        break;
                }
            }
            return currLine;
        }
    }
}
