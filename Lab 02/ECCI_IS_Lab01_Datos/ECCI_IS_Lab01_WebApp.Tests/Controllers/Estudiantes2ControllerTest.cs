using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECCI_IS_Lab01_WebApp.Controllers;
using ECCI_IS_Lab01_WebApp.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ECCI_IS_Lab01_WebApp.Tests.Controllers
{
    [TestClass]
    public class Estudiantes2ControllerTest
    {
        [TestMethod]
        public void TestCreateNotNullAndView()
        {
            Estudiante2Controller controller = new Estudiante2Controller();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result, "Null");
        }
        [TestMethod]
        public void TestEditFindANonExistentStudent()
        {
            Estudiante2Controller controller = new Estudiante2Controller();
            Estudiante newStudent = new Estudiante();
            ViewResult result = controller.Edit(newStudent.EstudianteID) as ViewResult;
            Assert.IsNull(result, "Null");
        }
    }
}
