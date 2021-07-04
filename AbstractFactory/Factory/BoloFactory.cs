using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Domain.Products.Bolo;
using System;

namespace AbstractFactory.Factory
{
    // Concrete Factory 1
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            return tipoBolo switch
            {
                TipoBolo.Chocolate => new BoloChocolate(),
                TipoBolo.Laranja => new BoloLaranja(),
                _ => throw new ArgumentOutOfRangeException(nameof(tipoMassa), "Tipo não implementado")
            };
        }
    }
}
