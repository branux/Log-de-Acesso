using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAcessoDemo.App.Dominio.Entidades
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
