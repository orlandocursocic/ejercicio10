using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio10;

namespace ejercicio10Test
{
    /// <summary>
    /// Esta es la clase de test de una calculadora
    /// </summary>
    [TestClass]
    public class CalculadoraTest
    {

        [TestMethod]
        public void TestSumar()
        {
            Calculadora sut = new Calculadora();
            int resultado = sut.Sumar(4, 5);

            Assert.AreEqual(9, resultado);
        }
    }
}
