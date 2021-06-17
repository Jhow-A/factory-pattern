using System;

namespace PizzariaNoFactory
{
    /* Programado para implementações e não para interfaces
     * Forte acoplamento entre as classes
     * O cliente (Pizzaria) conhece os detalhes de implementação
     * A alteração em qualquer produto (inclusão ou remoção) é difícil de ser feita pois exige alterar o cliente
     * Código difícil de dar manutenção
     */
    public static class Pizzaria
    {
        public static void PedirPizza()
        {
            PizzaCalabresa pizzaCalabresa;
            PizzaMussarela pizzaMussarela;

            Console.WriteLine("====== Pizzaria ======");
            Console.Write("Tecle (C)alabresa ou (M)ussarela para escolher a pizza: ");
            var escolha = Console.ReadLine().ToUpper();

            if (escolha.Equals("C"))
            {
                pizzaCalabresa = new PizzaCalabresa(); // Acoplamento de classes e violação de OCP 
                pizzaCalabresa.Preparar();
                pizzaCalabresa.Assar(10);
                pizzaCalabresa.Embalar();

                Console.WriteLine("Pizza concluída");
            }
            else if (escolha.Equals("M"))
            {
                pizzaMussarela = new PizzaMussarela();
                pizzaMussarela.Preparar();
                pizzaMussarela.Assar(10);
                pizzaMussarela.Embalar();

                Console.WriteLine("Pizza concluída");
            }
            else
            {
                Console.WriteLine("Escolha inválida");
            }
        }
    }
}
