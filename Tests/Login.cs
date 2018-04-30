using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AYD_P;


namespace Tests
{
    [TestClass]
    public class Login
    {
        Form1 Testform = new Form1();
        [TestMethod]
        public void TestLogin()
        {
            
            Boolean Testbol = true;
            Boolean Valoresperado = Testform.validar_login("usuario", "contraseña");
            Assert.AreEqual(Testbol, Valoresperado);
        }
    }
}
