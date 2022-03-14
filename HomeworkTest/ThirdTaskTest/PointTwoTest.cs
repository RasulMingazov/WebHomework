using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HomeworkTest.ThirdTaskTest
{
    [TestClass]
    public class PointTwoTest
    {
        ThirdTask.RegEx regEx = new ThirdTask.RegEx();

        [TestMethod]
        public void Test()
        {
            string[] input = { "010101", "111", "00", "101", "0110", "001", "11101" };
            string expected = "010101 111 00 101";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                regEx.PrintRightBinaryCodes(input);

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
