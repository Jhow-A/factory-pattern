using System;

namespace PizzariaNoFactory
{
    public class PizzaCalabresa
    {
        public string Nome { get; set; }

        public PizzaCalabresa()
        {
            Nome = "Pizza de Calabresa";
        }

        public void Preparar() => Console.WriteLine($"Preparando pizza de {this.Nome}");

        public void Assar(int tempo) => Console.WriteLine($"Pizza de {this.Nome} assando por {tempo} minutos");

        public void Embalar() => Console.WriteLine($"Embalando pizza de {this.Nome}");
    }
}
