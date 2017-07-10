using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio10;

namespace ejercicio10Test
{
    [TestClass]
    public class CalculadoraConFicheroTest
    {
        [TestMethod]
        public void TestSumarGuardando()
        {
            CalculadoraConFichero sut = new CalculadoraConFichero();
            sut.calculadora = new CalculadoraDel9();
            sut.ficheroService = new FicheroServiceDeMentira();

            sut.SumarGuardando(4,5);

        }
    }

    /// <summary>
    /// Clase dummie para probar el funcionamiento de CalculadoraConFichero sin disponer de la
    /// implementacion de la clase Calculadora
    /// </summary>
    public class CalculadoraDel9 : ICalculadora
    {
        public int Sumar(int a, int b)
        {
            return 9;
        }
    }

    public class FicheroServiceDeMentira : IFicheroService
    {
        void IFicheroService.GuardaNumero(int c)
        {
        }
    }
}
