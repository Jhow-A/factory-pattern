using System;

namespace PizzariaSimpleFactory
{
    public sealed class PizzariaSimpleFactory
    {
        public static Pizza FazerPizza(string tipo)
        {
            return tipo switch
            {
                "C" => new PizzaCalabresa(),
                "M" => new PizzaMussarela(),
                _ => throw new Exception($"A pizza de '{tipo}' não foi criada")
            };
        }
    }
}
