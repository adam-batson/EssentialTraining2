using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining2;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSaucesTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauces();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //expect to pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            //expect to fail
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
