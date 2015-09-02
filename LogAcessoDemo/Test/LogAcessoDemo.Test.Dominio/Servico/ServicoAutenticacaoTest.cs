using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LogAcessoDemo.Test.Dominio.Servico
{
    [TestClass]
    public class ServicoAutenticacaoTest
    {

        //dado AutenticacaoServico

        [TestMethod]
        public void Verificando_o_método_ObterDadosAposAutenticando()
        {
            //arrange
            var mockRep = new Mock<App.Dominio.Interfaces.Repositorio.IUsuarioRepositorio>();
            mockRep.Setup(mr => mr.ObterUsuarioAutenticado("user_silva","senha123")).Returns(ObterUsuarioStub);
            var _usuarioServ = new App.Dominio.Servico.AutenticacaoServico(mockRep.Object);

            //act
            var usuario = _usuarioServ.ObterDadosAposAutenticar("user_silva", "senha123");

            //assert
            Assert.IsNotNull(usuario);
            Assert.AreEqual("nome da silva", usuario.Nome);
            
        }

        private App.Dominio.Entidades.Usuario ObterUsuarioStub()
        {
            return new App.Dominio.Entidades.Usuario("nome da silva", "user_silva", "senha123");
        }
    }
}
