
namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Cliente : EntidadeBase
    {
        protected Cliente()
        { }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; protected set; }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;

            return true;
        }
    }
}
