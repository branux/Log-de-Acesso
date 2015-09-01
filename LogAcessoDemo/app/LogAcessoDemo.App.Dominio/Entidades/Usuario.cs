
using System.Collections.Generic;
namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        protected Usuario()
        { }

        public Usuario(string nome, string login, string senha)
        {
            Nome = nome ?? "";
            Login = login ?? "";
            Senha = senha ?? "";
            Validar();
        }

        public string Nome { get; protected set; }
        public string Login { get; protected set; }
        public string Senha { get; protected set; }


        public override void Validar()
        {
            var mensagens = new List<string>();

            if (Nome.Trim().Length < 6)
                mensagens.Add("O nome do usuário deve ter entre ao menos 6 caracteres");

            if (Login.Trim().Length < 6 || Login.Trim().Length > 12)
                mensagens.Add("O login do usuário deve ter entre 6 e 12 caracteres");

            if (Senha.Trim().Length < 6)
                mensagens.Add("A senha do usuário deve ter ao menos 6 caracteres");

            if (mensagens.Count > 0)
                throw new Exceptions.UsuarioInvalidoException(UnirMensagensErro(mensagens));


        }
    }
}
