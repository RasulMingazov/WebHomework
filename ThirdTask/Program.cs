using System;
using System.Text.RegularExpressions;

namespace ThirdTask
{
    class Program
    {
        static ThirdTask.RegEx regEx = new ThirdTask.RegEx();
        static void Main(string[] args)
        {
            regEx.PrintMinimumThreeEvenGroups();
        }
    }
}
