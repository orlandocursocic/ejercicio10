using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// Metodo de suma de numeros enteros
        /// </summary>
        /// <param name="a">Primer sumando</param>
        /// <param name="b">Segundo sumando</param>
        /// <returns>La suma</returns>
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
