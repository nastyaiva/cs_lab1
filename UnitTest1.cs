using System.Drawing;
using NUnit.Framework;

// Задание 2
//namespace test1
//{
//    public class RectangleTests
//    {
//        [Test]
//        public void CalculateArea_ShouldReturnCorrectArea()
//        {
//            // Arrange
//            var rectangle = new Rectangle(5, 10);

//            // Act
//            var area = rectangle.Area;

//            // Assert
//            Assert.That(area, Is.EqualTo(50));
//        }

//        [Test]
//        public void CalculatePerimeter_ShouldReturnCorrectPerimeter()
//        {
//            // Arrange
//            var rectangle = new Rectangle(5, 10);

//            // Act
//            var perimeter = rectangle.Perimeter;

//            // Assert
//            Assert.That(perimeter, Is.EqualTo(30));
//        }
//    }
//}

//Задание 3


[TestFixture]
public class FigureTests
{
    [Test]
    public void TestPerimeterOfTriangle()
    {
        var point1 = new Point(0, 0);
        var point2 = new Point(4, 0);
        var point3 = new Point(4, 3);
        var figure = new Figure(point1, point2, point3);

        double expectedPerimeter = 12; // 4 + 3 + 5
        Assert.AreEqual(expectedPerimeter, figure.PerimeterCalculator());
    }

    [Test]
    public void TestPerimeterOfQuadrilateral()
    {
        var point1 = new Point(0, 0);
        var point2 = new Point(4, 0);
        var point3 = new Point(4, 3);
        var point4 = new Point(0, 3);
        var figure = new Figure(point1, point2, point3, point4);

        double expectedPerimeter = 14; // 4 + 3 + 4 + 3
        Assert.AreEqual(expectedPerimeter, figure.PerimeterCalculator());
    }

    [Test]
    public void TestPerimeterOfPentagon()
    {
        var point1 = new Point(0, 0);
        var point2 = new Point(4, 0);
        var point3 = new Point(4, 3);
        var point4 = new Point(2, 5);
        var point5 = new Point(0, 3);
        var figure = new Figure(point1, point2, point3, point4, point5);

        double expectedPerimeter = 18.472; // Периаметр рассчитывается по координатам
        Assert.AreEqual(expectedPerimeter, Math.Round(figure.PerimeterCalculator(), 3));
    }
}



