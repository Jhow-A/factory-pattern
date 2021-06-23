using FactoryMethod.Pizzaria;
using System;

namespace FactoryMethod.Factory
{
    // Concrete Creator
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "C" => new PizzaCalabresaRJ(),
                "M" => new PizzaMussarelaRJ(),
                _ => throw new Exception($"A pizza '{tipo}' não foi criada")
            };
        }
    }
}
