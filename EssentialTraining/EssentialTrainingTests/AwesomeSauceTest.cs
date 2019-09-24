using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var instanceTest = new AwesomeSauce();
            instanceTest.Sauces.Add("Tobasco");
            instanceTest.Sauces.Add("Cholula");
            instanceTest.Sauces.Add("Trailer Trash");

            // Expect to true
            Assert.IsTrue(instanceTest.IsSauceAwesome("Trailer Trash"));

            // Expect to false
            Assert.IsFalse(instanceTest.IsSauceAwesome("Ketchup"));

        }
    }
}
