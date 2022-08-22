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
            Random randomCount = new Random();
            Random randomBracket = new Random();
            int randomNumber;
            int count= randomCount.Next(2, 20);
            string bracketString = "";
            char leftBracket = '(';
            char rightBracket = ')';
            bool isCorrect=false;
            int leftBracketCount=0;
            int rightBracketCount=0;

            for (int i=0;i<count;i++)
            {
                randomNumber = randomBracket.Next(0, 2);

                if (randomNumber==0)
                {
                    bracketString += leftBracket;
                }
                else
                {
                    bracketString += rightBracket;
                }
            }

            if (bracketString.Length%2==0)
            {
                foreach (char k in bracketString)
                {
                    if (k==leftBracket)
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
                Console.Write(" является корректным скобочным выражением с максимальной глубиной вложенности " + rightBracketCount);
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