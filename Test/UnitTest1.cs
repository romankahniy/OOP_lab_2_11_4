using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, OOP_lab_2_11_4.Program.AmountOfZeroes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, OOP_lab_2_11_4.Program.Multiplication(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }
    }
}
