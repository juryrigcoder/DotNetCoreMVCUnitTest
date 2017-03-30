using System.ComponentModel;
using CoreUnitTesting.Controllers;
using CoreUnitTesting.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Sdk;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test2()
        {
            var model = new HomeModel();

            var result = model.msg;

            Assert.NotNull(result);
        }
    }
}