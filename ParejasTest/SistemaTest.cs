using Xunit;
using System.Collections.Generic;

namespace Parejas
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new Persona() , new Persona(), false},
            // new object[] { new Persona("A", Sexo.H, 20) , new Persona("B", Sexo.M, 26), false},
            // new object[] { new Persona("A", Sexo.H, 20) , new Persona("B", Sexo.M, 21), true},
        };

    }
}