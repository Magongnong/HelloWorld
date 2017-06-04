using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
using BusinessService;
//using System.Web.Http;
using Moq;

namespace WebApi.Tests
{
    [TestClass]
    public class TestGreetingController
    {
        [TestMethod]
        public void GetGreeting_ShouldReturnCorrectGreeting()
        {
            //arrange
            var correctGreeting = "Hello World";

            var mockSvc = new Mock<IGreetingService>();
            mockSvc.Setup(x => x.GetHelloWorld()).Returns("Hello World");

            var controller = new HelloWorldController(mockSvc.Object);

           
            var result = controller.Get();
            Assert.IsNotNull(result);
            Assert.AreEqual(correctGreeting, result);
        }
    }
}
