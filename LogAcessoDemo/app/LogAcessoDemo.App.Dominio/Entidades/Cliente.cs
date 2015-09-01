using System.Collections.Generic;

namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Cliente : EntidadeBase
    {
        protected Cliente()
        { }

        public Cliente(string nome)
        {
            Nome = nome ?? "";
            Validar();
        }

        public string Nome { get; protected set; }

        public override void Validar()
        {
            var msg = new List<string>();

            if (Nome.Trim().Length < 6)
                msg.Add("O nome do cliente deve ter ao menos 6 caracteres");


            throw new Exceptions.ClienteInvalidoException(UnirMensagensErro(msg));

        }
    }
}
