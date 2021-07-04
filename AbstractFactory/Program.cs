using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtém as fábricas
            MassasAbstractFactory boloFactory = MassasAbstractFactory.CriarFabricaDeMassa(TipoMassa.Bolo);
            MassasAbstractFactory pizzaFactory = MassasAbstractFactory.CriarFabricaDeMassa(TipoMassa.Pizza);

            // Usando factory de bolo
            var boloChocolate = boloFactory.CriarMassa((TipoMassa)TipoBolo.Chocolate);
            var boloLaranja = boloFactory.CriarMassa((TipoMassa)TipoBolo.Laranja);

            // Usando factory de pizza
            var pizzaMussarela = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Mussarela);
            var pizzaCalabresa = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Calabresa);

            // Exibe os detalhes
            Console.WriteLine(boloChocolate.ToString());
            Console.WriteLine(boloLaranja.ToString());
            Console.WriteLine(pizzaMussarela.ToString());
            Console.WriteLine(pizzaCalabresa.ToString());
        }
    }
}
