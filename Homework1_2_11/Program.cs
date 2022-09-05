using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber;
            int minCountBracket = 2;
            int maxCountBracket = 19;
            int countBracket= random.Next(minCountBracket, maxCountBracket+1);
            string bracketString = "";
            char leftBracket = '(';
            char rightBracket = ')';
            bool isCorrect=false;
            int leftBracketCount=0;
            int rightBracketCount=0;
            int evenNumber = 2;
            int countBracketType = 2;
            int maxGamut = 0;

            for (int i=0;i<countBracket; i++)
            {
                randomNumber = random.Next(0, countBracketType);

                if (randomNumber==0)
                {
                    bracketString += leftBracket;
                }
                else
                {
                    bracketString += rightBracket;
                }
            }

            if (bracketString.Length%evenNumber==0)
            {
                int gamut;
                foreach (char SymbolOfBracketString in bracketString)
                {
                    if (SymbolOfBracketString == leftBracket)
                    {
                        leftBracketCount++;
                    }
                    else
                    {
                        rightBracketCount++;
                    }

                    if (rightBracketCount> leftBracketCount)
                    {
                        break;
                    }

                    gamut = leftBracketCount - rightBracketCount;

                    if (maxGamut<gamut)
                    {
                        maxGamut = gamut;
                    }

                }

                if (leftBracketCount== rightBracketCount)
                {
                    isCorrect = true;
                }
            }

            if (isCorrect)
            {
                Console.Write("Строка ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(bracketString);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" является корректным скобочным выражением с максимальной глубиной вложенности " + maxGamut);
            }
            else
            {
                Console.Write("Строка ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(bracketString);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" не является корректным скобочным выражением");
            }
        }
    }
}