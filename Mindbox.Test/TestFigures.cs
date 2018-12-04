using Mindbox.Figures;
using Xunit;

namespace Mindbox.Test
{
    [Collection("Figures tests")]
    public class TestFigures
    {
        [Fact(DisplayName = "Test triangle area 1")]
        public void TestTriangleArea1()
        {
            var t = new Triangle(3, 4, 5);
            Assert.Equal(6d, t.GetArea());
        }

        [Fact(DisplayName = "Test triangle area 2")]
        public void TestTriangleArea2()
        {
            var t = new Triangle(3, 4.5, 5);
            Assert.Equal(6.66585281490673d, t.GetArea(), 0);
        }

        [Fact(DisplayName = "Test circle area")]
        public void TestCircleArea()
        {
            var c = new Circle(3);
            Assert.Equal(28.2743338823081d, c.GetArea(), 0);
        }

        [Fact(DisplayName = "Test triangle IsRight 1")]
        public void TestTriangleTrue()
        {
            var t = new Triangle(3, 4, 5);
            Assert.True(t.IsRight);
        }

        [Fact(DisplayName = "Test triangle IsRight 2")]
        public void TestTriangleFalse()
        {
            var t = new Triangle(3, 6, 5);
            Assert.False(t.IsRight);
        }
    }
}
