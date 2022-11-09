using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void AreaMastReturnPi()
        {
            var c = new Circle(1);
            Assert.IsTrue(c.Area() == Math.PI);
        }

        [TestMethod]
        public void ConstructorMustReturnArgumentExcwption()
        {
            Assert.ThrowsException<ArgumentException>(delegate()
            {
                var c = new Circle(-100);
            });        
        }
    }
}
