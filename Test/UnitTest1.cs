using MyLibFigure;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleSquare1()
        {
            double Side1 = 3;
            double Side2 = 4;
            double Side3 = 5;
            double expected = 6;

            double actual = Figure.Square(Side1, Side2, Side3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleSquare2()
        {
            double Side1 = 4;
            double Side2 = 3;
            double Side3 = 6;
            double expected = 5.33;

            double actual = Figure.Square(Side1, Side2, Side3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CircleSquare1()
        {
            double Radius = 8;
            double expected = 200.96;

            double actual = Figure.Square(Radius);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CircleSquare2()
        {
            double Radius = 4.6;
            double expected = 66.44;

            double actual = Figure.Square(Radius);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleCheckTrue()
        {
            double Side1 = 3;
            double Side2 = 4;
            double Side3 = 5;
            bool expected = true;

            bool actual = Check.RightTriangle(Side1, Side2, Side3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleCheckFalse1()
        {
            double Side1 = 5;
            double Side2 = 3.3;
            double Side3 = 4;
            bool expected = false;

            bool actual = Check.RightTriangle(Side1, Side2, Side3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleCheckFalse2()
        {
            double Side1 = 4;
            double Side2 = 3;
            double Side3 = 6;
            bool expected = false;

            bool actual = Check.RightTriangle(Side1, Side2, Side3);
            Assert.Equal(expected, actual);
        }
    }
}