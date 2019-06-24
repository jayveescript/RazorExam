using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeController = new HomeController();
            var result = homeController.Index() as ViewResult;
            Assert.IsInstanceOfType(result.Model, typeof(TestModel));
        }
    }
}
