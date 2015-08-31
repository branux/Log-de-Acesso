using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAcessoDemo.App.Dominio.Entidades;
using LogAcessoDemo.App.Dominio.Exceptions;

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

        [TestMethod]
        [ExpectedException(typeof(ClienteInvalidoException))]
        public void Não_poderá_ser_validado_se_nome_for_nulo_ou_branco()
        {
            //arrange
            var cliente = new Cliente(null);
        }
    }
}
