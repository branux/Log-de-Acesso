using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAcessoDemo.App.UI.WebMVC.Controllers;
using System.Web.Mvc;

namespace LogAcessoDemo.Test.UI.WebMVC.Controllers
{
    [TestClass]
    public class ControllerHomeTest
    {

        //DADO O HOMECONTROLLER
        [TestMethod]
        public void Ao_bater_no_Home_Index_deverá_renderizar_a_view_Index()
        {
            //arrange
            var controller = new HomeController();

            //act
            var result = controller.Index() as ViewResult;

            //assert
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
