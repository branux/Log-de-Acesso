
using System.Collections.Generic;

namespace LogAcessoDemo.App.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public virtual int ID { get; protected set; }

        public abstract void Validar();

        public string UnirMensagensErro(IList<string> msg)
        {
            return string.Join(" | ", msg);
        }

    }
}
