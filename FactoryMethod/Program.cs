using FactoryMethod.Factory;
using FactoryMethod.Pizzaria;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Pizzaria ========== \n");
            Console.Write("Informe o local São Paulo (SP) ou Rio de Janeiro (RJ): ");
            var localEscolhida = Console.ReadLine().ToUpper();

            Console.Write("Tecle (C)alabresa ou (M)ussarela para escolher a pizza: ");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzaria = PizzariaSimpleFactory.CriarPizzaria(localEscolhida);
                Pizza pizza = pizzaria.MontarPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("Pizza concluída com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
