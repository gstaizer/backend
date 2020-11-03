using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIdentifierLibrary
{
    public class CheckIdentifierLibrary
    {
        private const int exIndex = -1;
        private int incorrectIndex = exIndex;
        private bool isEmpty = false;

        private void resetState()
        {
            incorrectIndex = exIndex;
            isEmpty = false;
        }

        public bool IsEmpty()
        {
            return isEmpty;
        }

        public int GetIncorrectIndex()
        {
            return incorrectIndex;
        }

        private bool IsLetter(char ch)
        {
            return 'a' <= ch && ch <= 'z' || 'A' <= ch && ch <= 'Z';
        }

        public bool IsIdentifier(string value)
        {
            resetState();

            if (value.Length == 0)
            {
                isEmpty = true;
                return false;
            }

            if (!IsLetter(value[0]))
            {
                incorrectIndex = 0;
                return false;
            }

            for (int i = 1; i < value.Length; i++)
            {
                if (!(IsLetter(value[i]) || char.IsDigit(value[i])))
                {
                    incorrectIndex = i;
                    return false;
                }
            }
            return true;
        }
    }
}
