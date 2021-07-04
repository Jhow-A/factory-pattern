using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Domain.Products.Pizza;
using System;

namespace AbstractFactory.Factory
{
    // Concrete Factory 2
    class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            return tipoPizza switch
            {
                TipoPizza.Mussarela => new PizzaMussarela(),
                TipoPizza.Calabresa => new PizzaCalabresa(),
                _ => throw new ArgumentOutOfRangeException(nameof(tipoMassa), "Tipo não implementado")
            };
        }
    }
}
