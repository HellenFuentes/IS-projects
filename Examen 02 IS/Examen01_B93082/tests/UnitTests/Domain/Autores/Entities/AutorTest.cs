using Xunit;
using Examen01_B93082.Domain.Autores.Entities;
using FluentAssertions;

namespace Lab2.IntegrationTests.Domain.Autores.Entities
{
    public class AutorTest
    {
        [Fact]
        public void TwoAutorsWithSameValuesMustBeTheSame()
        {
            string Nombre = "Joseph";
            string Apellido = "Calderon";
            Autor autor1 = new Autor(Nombre, Apellido);
            Autor autor2 = new Autor(Nombre, Apellido);
            Assert.Equal(autor1.Nombre, autor2.Nombre);
            Assert.Equal(autor1.Apellido, autor2.Apellido);
        }
        [Fact]
        public void TwoAutorsWithDiferentValuesMustBeTheSame()
        {
            Autor autor1 = new Autor("Joseph", "Calderon");
            Autor autor2 = new Autor("Mauricio", "Ramirez");
            autor1.Should().NotBe(autor2);
        }

        [Fact]
        public void NewAutorShouldNotBeNull()
        {
            string Nombre = "Joseph";
            string Apellido = "Calderon";
            Autor autor1 = new Autor(Nombre, Apellido);
            autor1.Should().NotBeNull();
        }

    }
}