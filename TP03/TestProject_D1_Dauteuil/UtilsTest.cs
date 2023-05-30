

using TP03;

namespace TestProject_D1_Dauteuil
{
    public class UtilsTest
    {
        [Fact]
        public void TestGcd()
        {
            Assert.Equal(10, Utils.Gcd(10, 30));
            Assert.Equal(1, Utils.Gcd(10, 1));
            Assert.Equal(1, Utils.Gcd(3, 5));
            Assert.Equal(50, Utils.Gcd(150, 250));
        }
    }
}