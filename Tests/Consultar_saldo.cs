using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AYD_P;
namespace Tests
{
    [TestClass]
    public class Consultar_saldo
    {
        Form1 f = new Form1();
        [TestMethod]
        public void TestConsultar_saldo()
        {
            double valor = f.consultar_saldo("usuario");
            Assert.AreNotEqual(valor, -1);
        }
    }
}
