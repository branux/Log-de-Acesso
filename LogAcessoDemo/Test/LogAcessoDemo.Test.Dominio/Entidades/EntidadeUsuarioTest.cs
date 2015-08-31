using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAcessoDemo.App.Dominio.Entidades;
using LogAcessoDemo.App.Dominio.Exceptions;

namespace LogAcessoDemo.Test.Dominio.Entidades
{
    [TestClass]
    public class EntidadeUsuarioTest
    {

        //DADO UM USUÁRIO

        [TestMethod]
        public void Deverá_herdar_da_EntidadeBase()
        {
            Assert.IsTrue(typeof(Usuario).IsSubclassOf(typeof(EntidadeBase)), "Entidade não derivada da EntidadeBase");
        }


        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_nome_for_nulo_ou_branco()
        {
            //arrange
            var usuario = new Usuario(null, "fnalin", "123@qwe");

        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_login_for_nulo()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", null, "123@qwe");
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_login_for_empty()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "", "123@qwe");
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_login_tiver_menos_de_6_caracteres()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "12345", "123@qwe");
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_login_tiver_mais_de_12_caracteres()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "1234567890123", "123@qwe");
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_senha_a_for_nula()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "123456789012", null);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_a_senha_for_empty()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "123456789012", "");
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void Não_poderá_ser_validado_se_senha_tiver_menos_de_6_caracteres()
        {
            //arrange
            var usuario = new Usuario("Fabiano Nalin", "123456789012", "12345");
        }

    }
}
