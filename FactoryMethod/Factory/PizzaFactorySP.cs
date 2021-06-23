using FactoryMethod.Pizzaria;
using System;

namespace FactoryMethod.Factory
{
    // Concrete Creator
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "C" => new PizzaCalabresaSP(),
                "M" => new PizzaMussarelaSP(),
                _ => throw new Exception($"A pizza '{tipo}' não foi criada")
            };
        }
    }
}
