using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HomeworkTest.ThirdTaskTest
{
    [TestClass]
    public class PointOneTest
    {
        ThirdTask.RegEx regEx = new ThirdTask.RegEx();

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("0"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("-6"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("-0.5"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("0,5"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("+2"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("0,0(6)"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(regEx.IsRealRepeatingDecimalNumber("-0"));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsFalse(regEx.IsRealRepeatingDecimalNumber("001"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsFalse(regEx.IsRealRepeatingDecimalNumber("0,(35)00"));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.IsFalse(regEx.IsRealRepeatingDecimalNumber("-3,750"));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("343"));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.IsTrue(regEx.IsRealRepeatingDecimalNumber("1,01"));
        }
    }
}
