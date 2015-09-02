using LogAcessoDemo.App.Dominio.Interfaces.Repositorio;
using LogAcessoDemo.App.Dominio.Interfaces.Servico;

namespace LogAcessoDemo.App.Dominio.Servico
{
    public class AutenticacaoServico : IAutenticacaoServico
    {
        private readonly IUsuarioRepositorio _usuarioRepo;

        public AutenticacaoServico(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }
        public Entidades.Usuario ObterDadosAposAutenticar(string login, string senha)
        {
            return _usuarioRepo.ObterUsuarioAutenticado(login, senha);
        }

        public void Dispose()
        {
            _usuarioRepo.Dispose();
        }


    }
}
