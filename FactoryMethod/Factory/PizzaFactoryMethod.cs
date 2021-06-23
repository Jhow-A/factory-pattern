using FactoryMethod.Pizzaria;

namespace FactoryMethod.Factory
{
    // Creator
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontarPizza(string tipo) => CriarPizza(tipo);

        protected abstract Pizza CriarPizza(string tipo);
    }
}
