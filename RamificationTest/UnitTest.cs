using NUnit.Framework;
using GitLasson3Library;

namespace RamificationTest
{
    public class UnitTest
    {
        [TestCase(5, 5, 25)]
        [TestCase(-3, 0, -3)]
        [TestCase(1, 1, 1)]
        [TestCase(6, 8, -2)]
        public void Test1(double A, double B, double expected)
        {
            double actual = Lasson3Library.Task1(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, 2, "2 part")]
        [TestCase(0, 0, "Centre")]
        [TestCase(-3, 0, "2-3 part")]
        public void Test2(double X, double Y, string expected)
        {
            string actual = Lasson3Library.Task2(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3, 5, 5, 4, 3)]
        [TestCase(1, 2, 3, 3, 2, 1)]
        [TestCase(3, 2, 1, 3, 2, 1)]
        [TestCase(110, 80, 258, 258, 110, 80)]
        public void Test3(double A, double B, double C, double maxexpected, double averageexpected, double minexpected)
        {
            (double maxactual, double averageactual, double minactual) = Lasson3Library.Task3(A, B, C);

            Assert.AreEqual(maxexpected, maxactual);
            Assert.AreEqual(averageexpected, averageactual);
            Assert.AreEqual(minexpected, minactual);
        }


    }

}