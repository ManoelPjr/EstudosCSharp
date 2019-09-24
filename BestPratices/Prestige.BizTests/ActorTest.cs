using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";

            // Act
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParametirzedConstructor()
        {
            // Arrange
            var currentActor = new Actor("Manoel Pedro");
            string expected = "Manoel Pedro";
            // Act
            string result = currentActor.ActorName;
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
