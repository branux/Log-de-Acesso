
namespace LogAcessoDemo.App.Dominio.Interfaces.Servico
{
    public interface IAutenticacaoServico : System.IDisposable
    {
        Entidades.Usuario ObterDadosAposAutenticar(string login, string senha);
    }
}
