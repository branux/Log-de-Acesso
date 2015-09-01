
namespace LogAcessoDemo.App.Dominio.Interfaces.Servico
{
    public interface IAutenticacaoServico : System.IDisposable
    {
        Entidades.Usuario ObterDadosAposAutenticando(string login, string senha);
    }
}
