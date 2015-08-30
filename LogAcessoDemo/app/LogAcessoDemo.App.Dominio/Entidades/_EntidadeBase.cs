
namespace LogAcessoDemo.App.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public virtual int ID { get; set; }

        public abstract bool Validar();

    }
}
