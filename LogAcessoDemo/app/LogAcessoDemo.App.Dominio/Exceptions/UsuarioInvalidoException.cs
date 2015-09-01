
namespace LogAcessoDemo.App.Dominio.Exceptions
{
    public class UsuarioInvalidoException : System.Exception
    {
        public UsuarioInvalidoException(string mensagem)
            : base(mensagem)
        { }
    }
}
