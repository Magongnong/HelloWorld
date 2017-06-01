using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
//using System.Web.Http;

namespace WebApi.Tests
{
    [TestClass]
    public class TestGreetingController
    {
        [TestMethod]
        public void GetGreeting_ShouldReturnCorrectGreeting()
        {
            var correctGreeting = "Hello World";
            var controller = new HelloWorldController();

            var result = controller.Get();
            Assert.IsNotNull(result);
            Assert.AreEqual(correctGreeting, result);
        }
    }
}
