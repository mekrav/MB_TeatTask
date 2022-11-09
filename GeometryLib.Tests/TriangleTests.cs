using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ConstructorMustReturnArgumentExcwption()
        {
            //Не работала с тестами в реальных проектах, не знаю пишут ли два Assert-а в одном методе
            //Но рещила так написать, ибо они тестируют буквально один if
            Assert.ThrowsException<ArgumentException>(delegate ()
            {
                var t = new Triangle(10,1,1);
            });
            Assert.ThrowsException<ArgumentException>(delegate ()
            {
                var t = new Triangle(-4, 5, 3);
            });
        }

        [TestMethod]
        public void AreaMastReturnCorrectAnswer()
        {
            var t = new Triangle(3,4,5);
            Assert.IsTrue(t.Area() == 6);
        }

        [TestMethod]
        public void isOrthogonalMastReturnTrue()
        {
            var t = new Triangle(3, 4, 5);
            Assert.IsTrue(t.isOrthogonal());
        }

        [TestMethod]
        public void isOrthogonalMastReturnFalse()
        {
            var t = new Triangle(3, 4, 6);
            Assert.IsFalse(t.isOrthogonal());
        }

    }
}
