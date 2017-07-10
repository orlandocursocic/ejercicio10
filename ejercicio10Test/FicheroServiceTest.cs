using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio10;

namespace ejercicio10Test
{
    [TestClass]
    public class FicheroServiceTest
    {
        [TestMethod]
        public void TestGuardaNumero()
        {
            FicheroService sut = new FicheroService();

            sut.GuardaNumero(5);

            Assert.IsTrue(FicheroUtil.IsLlamado());
        }
    }
}
