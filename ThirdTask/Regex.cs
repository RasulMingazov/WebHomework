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
         */
        public void PrintEvenDigits()
        {
            NumbersSample(@"\b\d*[02468]\b");
        }

        /*
         * Point 4. Генерировать случайные положительные целые числа. 
         * Вывести первые 10 сгенерированных чисел, в которых нет трех четных цифр подряд. 
         * Остановить генератор, вывести общее количество сгенерированных чисел. 
         * Проверку осуществлять регулярным выражением. НЕ использовать математические операции для анализа числа
         */
        public void PrintNoThreeEvenDigitsInside()
        {
            NumbersSample(@"^([13579]|([02468]([13579]|([02468]([13579]|$))|$)))*$");
        }

        /*
         * Point 5. Генерировать случайные положительные целые числа. 
         * Вывести первые 10 сгенерированных чисел, которые содержат 
         * более 3 и менее 6 четных цифр и ни одной нечетной.
         * Остановить генератор, вывести общее количество сгенерированных чисел. 
         */
        public void PrintFromThreeToSixEven()
        {
            NumbersSample(@"\b[02468]{3,6}\b");
        }

        /*
         * Point 6. Генерировать случайные положительные целые числа.
         * Вывести первые 10 сгенерированных чисел, в которых 
         * есть как минимум два раза встречается группа из 2 четных цифр. 
         * Остановить генератор, вывести общее количество сгенерированных чисел. 
         */
        public void PrintMinimumThreeEvenGroups()
        {
            NumbersSample(@"\b\d*[02468]{2}\d*[02468]{2}\d*\b");
        }

        public Boolean IsValidPhoneNumber(String number)
        {
            return new Regex(@"^([+7]|8)[-]?(\d{3})(\d{3})[-]?(\d{2}[-]?)(\d{2})$")
                .IsMatch(number);
        }

        public Boolean IsValidPassword(String number)
        {
            return new Regex(@"(?=.*[0-9])(?=.*[-+!@#+$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*+-]{8,}")
                .IsMatch(number);
        }
         public Boolean IsValidDate(String number)
        {
            return new Regex(@"(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\1|
                            (?:(?:0?[1,3-9]|1[0-2])(\/|-|\.)(?:29|30)\2))
                            (?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:0?2(\/|-|\.)29\3
                            (?:(?:(?:1[6-9]|[2-9]\d)?
                            (?:0[48]|[2468][048]|[13579][26])|
                            (?:(?:16|[2468][048]|[3579][26])00))))$|^
                            (?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4
                            (?:(?:1[6-9]|[2-9]\d)?\d{2})")
                .IsMatch(number);
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
