using System;

namespace PizzariaSimpleFactory
{
    /* Programando para abstrações e não implementações
     * Encapsulmento do que varia e código mais flexível
     * Centralização da lógica de criação dos objetos em um único local facilitando manutenção
     */
    public static class Pizzaria
    {
        public static void PedirPizza()
        {
            Console.WriteLine("====== Pizzaria ======");
            Console.Write("Tecle (C)alabresa ou (M)ussarela para escolher a pizza: ");
            var escolha = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzariaSimpleFactory.FazerPizza(escolha);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluída");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
