using System.Collections.Generic;

namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Cliente : EntidadeBase
    {
        protected Cliente()
        { }

        public Cliente(string nome)
        {
            Nome = nome;
            Validar();
        }

        public string Nome { get; protected set; }

        public override void Validar()
        {
            var msg = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                msg.Add("O nome do cliente deve ser preenchido");


            throw new Exceptions.ClienteInvalidoException(UnirMensagensErro(msg));

        }
    }
}
