using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAcessoDemo.App.Dominio.Entidades;

namespace LogAcessoDemo.Test.Dominio.Entidades
{
    [TestClass]
    public class EntidadeClienteTest
    {
        //DADO UM CLIENTE

        [TestMethod]
        public void Deverá_herdar_da_EntidadeBase()
        {
            Assert.IsTrue(typeof(Cliente).IsSubclassOf(typeof(EntidadeBase)), "Entidade não derivada da EntidadeBase");
        }
    }
}
