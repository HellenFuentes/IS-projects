using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECCI_IS_Lab01_WebApp.Controllers;
using ECCI_IS_Lab01_WebApp.Models;
using System.Web.Mvc;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ECCI_IS_Lab01_WebApp.Tests.Controllers
{
    [TestClass]
    public class PaisControllerTest
    {
        [TestMethod]
        public void TestIndexNotNullAndView()
        {
            PaisController controller = new PaisController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result, "Null");
            Assert.AreEqual("Index", result.ViewName, "ViewName");
        }
        [TestMethod]
        public void TestDetailsNotNullAndView()
        {
            PaisController controller = new PaisController();
            ViewResult result = controller.Details("CRC") as ViewResult;
            Assert.IsNotNull(result, "Null");
            Assert.AreEqual("Details", result.ViewName, "ViewName");
        }
        [TestMethod]
        public void TestCreateNotNullAndView()
        {
            PaisController controller = new PaisController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result, "Null");
            Assert.AreEqual("Create", result.ViewName, "ViewName");
        }
        [TestMethod]
        public void TestEditNotNullAndView()
        {
            PaisController controller = new PaisController();
            ViewResult result = controller.Edit("CRC") as ViewResult;
            Assert.IsNotNull(result, "Null");
            Assert.AreEqual("Edit", result.ViewName, "ViewName");
        }
        [TestMethod]
        public void TestDetailsViewDataMock()
        {
            // Arrange
            var mockDb = new Mock<ECCI_IS_Lab01_DatosEntities3>();
            string id = "CRC";
            Pai pai = new Pai() { Id = "CRC", Nombre = "Costa Rica" };
            mockDb.Setup(m => m.Pais.Find(id)).Returns(pai);
            PaisController controller = new PaisController(mockDb.Object);

            // Act
            ViewResult result = controller.Details(id) as ViewResult;
            // Assert
            Assert.AreEqual(result.Model, pai);
        }

        [TestMethod]
        public void TestIndexViewDataMock()
        {
            // Arrange
            var paises = new List<Pai>
             {
             new Pai() { Id = "CRC", Nombre = "Costa Rica" },
             new Pai() { Id = "EUA", Nombre = "Estados Unidos de America" },
             new Pai() { Id = "MEX", Nombre = "Mexico" },
             new Pai() { Id = "BRA", Nombre = "Brazil" }
             }.AsQueryable();
            var mockDbSet = new Mock<DbSet<Pai>>();
            mockDbSet.As<IQueryable<Pai>>().Setup(m => m.Provider).Returns(paises.Provider);
            mockDbSet.As<IQueryable<Pai>>().Setup(m => m.Expression).Returns(paises.Expression);
            mockDbSet.As<IQueryable<Pai>>().Setup(m => m.ElementType).Returns(paises.ElementType);
            mockDbSet.As<IQueryable<Pai>>().Setup(m =>
           m.GetEnumerator()).Returns(paises.GetEnumerator());
            var mockDb = new Mock<ECCI_IS_Lab01_DatosEntities3>();
            mockDb.Setup(m => m.Pais).Returns(mockDbSet.Object);
            PaisController controller = new PaisController(mockDb.Object);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            List<Pai> pais = (List<Pai>)result.ViewData.Model;
            // Assert
            Assert.AreEqual(4, pais.Count);
        }
    }
}
