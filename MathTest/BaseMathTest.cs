using MathLib;
using Xunit;

namespace MathTest
{
    public class BaseMathTest
    {

        public BaseMathTest()
        {

        }

        [Fact]
        public void AddTest()
        {
            int a = 1;
            int b = 22;

            int c = BasicMath.Add(a, b);

            Assert.Equal(23, c);
        }

        [Fact]
        public void SubTest()
        {
            int a = 1;
            int b = 22;

            int c = BasicMath.Sub(a, b);

            Assert.Equal(-21, c);
        }

        [Fact]
        public void DivTest()
        {
            int a = 7;
            int b = 2;

            int c = BasicMath.Div(a, b);

            Assert.Equal(3, c);
        }

        [Fact]
        public void MulTest()
        {
            int a = 7;
            int b = 2;

            int c = BasicMath.Mul(a, b);

            Assert.Equal(14, c);
        }
    }

}
