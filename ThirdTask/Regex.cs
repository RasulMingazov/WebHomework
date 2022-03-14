using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ThirdTask
{
    public class RegEx
    {
        /*
         * Point 1. Напишите регулярное выражения для вещественного числа с периодом.
         * Подходят: 0, -6, -0.5, +2, 0,0(64),
         * Не подходят: -0, 001, 0,(35)00, -3,750
         */
        public Boolean IsRealRepeatingDecimalNumber(String str)
        {
            return new Regex(@"^((([+-]?[1-9]\d*)|0)([.,]\d?[1-9]*)?|[+-]0[.,]\d?[1-9]*)(\(\d*\))?$")
                .IsMatch(str);
        }

        /*
         * Point 2. На вход подается массив строк, каждая строка представляет собой двоичный код.
         * Правильным кодом называется строка, которая состоит либо только из нулей, либо только из единиц,
         * либо нули и единицы в ней чередуются 
         * Например, 010101, 11, 00, 101 - правильные коды, 0110, 001, 11101 - неправильные.
         * Написать программу с использованием регулярных выражений, которая выводит строки,
         * представляющих собой правильный код (использовать matches).
         */
        public void PrintRightBinaryCodes(string[] BinaryCodeArray)
        {
            MatchCollection matches = new Regex(@"\b(1+|0+|((([1][0])+[1]?)+)|(([0][1])+[0]?)+)\b")
                .Matches(string
                .Join(" ", BinaryCodeArray));
            PrintMatches(matches);
        }

        /*
         * Point 3. Генерировать случайные положительные целые числа.
         * Вывести первые 10 сгенерированных четных чисел, остановить генератор,
         * вывести общее количество сгенерированных чисел.
         * Проверку на четность осуществлять регулярным выражением.
         * НЕ использовать математические операции (использовать matches).
         */
        public void PrintEvenNumbers()
        {
            NumbersSample(@"\b\d*[02468]\b");
        }

        public void PrintNoThreeEvenNumbers()
        {
            NumbersSample(@"");
        }

        /*
         Utility methods
         */
        public void PrintMatches(MatchCollection matches)
        {
            Console.WriteLine(
                 string
             .Join(" ", matches
             .Cast<Match>()
             .Select(m => m.Value)
             .ToArray()));
        }

        public void NumbersSample(String RegexValue)
        {
            Random random = new Random();
            int AllCounter = 0, EvenCounter = 0;

            while (EvenCounter < 10)
            {
                int RandomValue = random.Next();
                if (new Regex(RegexValue).IsMatch(RandomValue.ToString()))
                {
                    Console.WriteLine(RandomValue);
                    EvenCounter++;
                }
                AllCounter++;
            }
            Console.WriteLine("Sum of generated random numbers is " + AllCounter);

        }
    }
}
