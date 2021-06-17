using System;

namespace PizzariaSimpleFactory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Pizza de Mussarela";
        }

        public override void Preparar() => Console.WriteLine($"Preparando pizza de {this.Nome}");

        public override void Assar(int tempo) => Console.WriteLine($"Pizza de {this.Nome} assando por {tempo} minutos");

        public override void Embalar() => Console.WriteLine($"Embalando pizza de {this.Nome}");
    }
}
