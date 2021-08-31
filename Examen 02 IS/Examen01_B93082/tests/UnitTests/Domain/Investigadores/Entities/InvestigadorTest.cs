using Xunit;
using Examen01_B93082.Domain.Investigadores.Entities;
using FluentAssertions;

namespace Examen01_B93082.UnitTests.Domain.Investigadores.Entities
{
    public class InvestigadorTest
    {
        [Fact]
        public void TwoInvestigadoresWithSameValuesMustBeTheSame()
        {
            string Nombre = "Ana Cubero Valverde";
            string MaximoGrado = "Doctora";
            int id = 0;
            Investigador investigador1 = new Investigador(Nombre, MaximoGrado,id);
            Investigador investigador2 = new Investigador(Nombre, MaximoGrado,id);
            Assert.Equal(investigador1.Nombre, investigador2.Nombre);
            Assert.Equal(investigador1.MaximoGrado, investigador2.MaximoGrado);
            Assert.Equal(investigador1.Id, investigador2.Id);
        }
        [Fact]
        public void TwoAutorsWithDiferentValuesMustBeTheSame()
        {
            Investigador investigador1 = new Investigador("Joseph Matamoros Ferrer", "Master",0);
            Investigador investigador2 = new Investigador("Mauricio Ramirez Calderon", "Lic",0);
            investigador1.Should().NotBe(investigador2);
        }

        [Fact]
        public void NewAutorShouldNotBeNull()
        {
            string Nombre = "Marta Quesada";
            string MaximoGrado = "Doctora";
            Investigador investigador = new Investigador(Nombre, MaximoGrado);
            investigador.Should().NotBeNull();
        }
    }
}
