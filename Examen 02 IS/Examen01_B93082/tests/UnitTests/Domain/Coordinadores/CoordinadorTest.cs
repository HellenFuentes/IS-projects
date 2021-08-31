using System;
using Examen01_B93082.Domain.Coordinadores.Entities;
using Xunit;

namespace Lab2.UnitTests.Domain.Coordinadores
{
    public class CoordinadorTest
    {
        [Fact]
        public void TryCreateCoordinador()
        {
            string nombre = "Morita";
            DateTime FechaIniNombramiento = DateTime.MinValue;
            DateTime FechaFinNombramiento = DateTime.Today;

            Coordinador coordinador = new Coordinador(nombre, FechaIniNombramiento, FechaFinNombramiento)
            {
                Nombre = nombre,
                FechaInicioNombramiento = FechaIniNombramiento,
                FechaFinalNombramiento = FechaFinNombramiento,
            };
            Assert.True(nombre == coordinador.Nombre, "Not the same");
            Assert.True(FechaIniNombramiento == coordinador.FechaInicioNombramiento, "Not the same");
            Assert.True(FechaFinNombramiento == coordinador.FechaFinalNombramiento, "Not the same");
        }
        [Fact]
        public void TryverifyCoordinadorDate()
        {
            DateTime date = DateTime.MinValue;
            Coordinador coordinador = new Coordinador();
            Assert.False(coordinador.setDate(date));
        }

        [Fact]
        public void TryverifyCoordinadorMaxDate()
        {
            DateTime date = DateTime.Today;
            Coordinador coordinador = new Coordinador();
            Assert.True(coordinador.setDate(date));
        }
    }
}
