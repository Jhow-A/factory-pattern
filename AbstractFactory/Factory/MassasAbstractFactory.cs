using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using System;

namespace AbstractFactory.Factory
{
    //Abstract Factory
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriarMassa(TipoMassa tipoMassa);

        public static MassasAbstractFactory CriarFabricaDeMassa(TipoMassa tipoMassa)
        {
            return tipoMassa switch
            {
                TipoMassa.Pizza => new PizzaFactory(),
                TipoMassa.Bolo => new BoloFactory(),
                _ => throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null)
            };
        }
    }
}
