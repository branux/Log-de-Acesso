
namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        protected Usuario()
        { }

        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        public override bool Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;


            return true;
        }
    }
}
