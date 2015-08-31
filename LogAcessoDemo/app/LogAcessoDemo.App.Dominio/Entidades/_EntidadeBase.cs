
namespace LogAcessoDemo.App.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public virtual int ID { get; protected set; }

        public abstract bool Validar();

    }
}
