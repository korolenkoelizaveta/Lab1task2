using Lab1task2;
namespace Test2Lab1task2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double[] a = { 4 };
            double[] b = { 6 };
            var result = Second.Average(a, b);
            CollectionAssert.AreEqual(new double[] { 5, 0 }, result);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            double[] a = { 1, 2, 3, 4 };
            double[] b = { 2, 3, 4, 5 };
            var result = Second.Average(a, b);
            CollectionAssert.AreEqual(new double[] { 4.5, 3 }, result);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            double[] a = { -5, -10, -3 };
            double[] b = { -1, -2, -6 };
            var result = Second.Average(a, b);
            CollectionAssert.AreEqual(new double[] { -3, 0 }, result);
            Assert.Pass();
        }
    }
}
