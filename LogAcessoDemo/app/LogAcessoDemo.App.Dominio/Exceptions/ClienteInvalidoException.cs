
namespace LogAcessoDemo.App.Dominio.Exceptions
{
    public class ClienteInvalidoException: System.Exception
    {
        public ClienteInvalidoException(string mensagem)
            : base(mensagem)
        { }
    }
}
