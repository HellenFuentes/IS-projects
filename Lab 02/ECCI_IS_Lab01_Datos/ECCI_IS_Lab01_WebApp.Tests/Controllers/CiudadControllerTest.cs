using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECCI_IS_Lab01_WebApp.Controllers;
using ECCI_IS_Lab01_WebApp.Models;
using System.Web.Mvc;
namespace ECCI_IS_Lab01_WebApp.Tests.Controllers
{
    [TestClass]
    public class CiudadControllerTest
    {
        [TestMethod]
        public void TestIndexNotNull()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestIndexView()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void TestDetailsNotNull()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Details("CRC", "SJO") as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestDetailsView()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Details("CRC", "SJO") as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }
        [TestMethod]
        public void TestCreateNotNull()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestCreateView()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.AreEqual("Create", result.ViewName);
        }
        [TestMethod]
        public void TestEditNotNull()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Edit("CRC", "SJO") as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestEditView()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Edit("CRC", "SJO") as ViewResult;
            Assert.AreEqual("Edit", result.ViewName);
        }
        [TestMethod]
        public void TestDeleteNotNull()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Delete("CRC", "SJO") as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestDeleteView()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Delete("CRC", "SJO") as ViewResult;
            Assert.AreEqual("Delete", result.ViewName);
        }

        [TestMethod]
        public void TestDetailsViewData()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Details("CRC", "SJO") as ViewResult;
            Ciudad ciudad = (Ciudad)result.ViewData.Model;
            Assert.AreEqual("San Jose", ciudad.Nombre);
        }
        [TestMethod]
        public void TestIndexViewData()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Index() as ViewResult;
            List<Ciudad> ciudads = (List<Ciudad>)result.ViewData.Model;
            Assert.AreEqual(10, ciudads.Count);
        }
        [TestMethod]
        public void TestEditViewData()
        {
            CiudadController controller = new CiudadController();
            ViewResult result = controller.Edit("CRC", "SJO") as ViewResult;
            Ciudad ciudad = (Ciudad)result.ViewData.Model;
            Assert.AreEqual("San Jose", ciudad.Nombre);
        }
    }
}