using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Controllers;
using System.Web.Mvc;

namespace MusicShop.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
