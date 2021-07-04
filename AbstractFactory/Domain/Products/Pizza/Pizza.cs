using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products.Pizza
{
    // Abstract Product B
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
