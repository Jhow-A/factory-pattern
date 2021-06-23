using System;

namespace FactoryMethod.Factory
{
    public static class PizzariaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            return local switch
            {
                "SP" => new PizzaFactorySP(),
                "RJ" => new PizzaFactoryRJ(),
                _ => throw new Exception($"A pizzaria '{local}' não foi criada")
            };
        }
    }
}
