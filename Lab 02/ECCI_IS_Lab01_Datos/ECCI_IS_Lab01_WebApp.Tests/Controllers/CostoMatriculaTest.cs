using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECCI_IS_Lab01_WebApp.Controllers;
namespace ECCI_IS_Lab01_WebApp.Tests.Controllers
{
    [TestClass]
    public class CostoMatriculaTest
    {
        [TestMethod]
        public void TestCalcularCostoMatriculaNull()
        {
            // Arrange
            CostoMatricula costoMatricula = new CostoMatricula();
            // Act
            double costo = costoMatricula.calcularCostoMatricula(0, 0, false);
            // Assert
            Assert.IsNotNull(costo);
        }
        [TestMethod]
        public void TestCalcularCostoMatricula_01()
        {
            // Arrange
            CostoMatricula costoMatricula = new CostoMatricula();
            // Act
            double costo = costoMatricula.calcularCostoMatricula(22, 1, false);
            // Assert
            Assert.AreEqual(costo, 2050.0);
        }
        [TestMethod]
        public void TestCalcularCostoMatricula_02()
        {
            // Arrange
            CostoMatricula costoMatricula = new CostoMatricula();
            // Act
            double costo = costoMatricula.calcularCostoMatricula(4, 1, false);
            // Assert
            Assert.AreEqual(costo, 1975.0);
        }
        [TestMethod]
        public void TestCalcularCostoMatricula_03()
        {
            // Arrange
            CostoMatricula costoMatricula = new CostoMatricula();
            // Act
            double costo = costoMatricula.calcularCostoMatricula(5, 1, false);
            // Assert
            Assert.AreEqual(costo, 1975.0);
        }
    }
}
