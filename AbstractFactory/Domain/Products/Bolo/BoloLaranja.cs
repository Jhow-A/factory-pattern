using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products.Bolo
{
    sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}
