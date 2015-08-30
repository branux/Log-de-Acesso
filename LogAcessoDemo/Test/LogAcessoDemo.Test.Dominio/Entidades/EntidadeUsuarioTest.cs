using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAcessoDemo.App.Dominio.Entidades;

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
        public void Não_poderá_ser_validado_se_nome_for_nulo_ou_branco()
        {
            //arrange
            var usuario = new Usuario(null, "fnalin", "123@qwe");

            //act
            var usuarioEhValido = usuario.Validar();

            //assert
            Assert.AreEqual(false, usuarioEhValido);
        }
    }
}
