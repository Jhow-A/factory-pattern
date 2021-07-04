using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products.Bolo
{
    // Product A1
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de chocolate", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}
