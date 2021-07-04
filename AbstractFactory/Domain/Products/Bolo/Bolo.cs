using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products.Bolo
{
    // Abstract Product A
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
        {

        }
    }
}
