using DemoUnitTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace DemoUnitTestProject
{
    [TestClass]
    public class PageHome
    {
        [TestMethod]
        public void TestIndex()
        {
            var controller = new HomeController();

            var actionResult = controller.Index();
            var viewResult = (ViewResult)actionResult;
            var modele = viewResult.Model;
            var data = (Data)modele;
            Assert.IsTrue(data.Chaine == "Yes");
        }
    }
}
