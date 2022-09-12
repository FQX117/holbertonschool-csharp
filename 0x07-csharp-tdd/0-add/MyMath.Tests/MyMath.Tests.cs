using NUnit.Framework;

namespace MyMath.Tests
{
    [testc]
    public class Tests
    {
        [testm]
        public void addition()
        {
            int a = 4;
            int b = 5;
            int sum = Operations.add(a, b);
            Assert.AreEqual(a + b, sum);
        }
    }
}
