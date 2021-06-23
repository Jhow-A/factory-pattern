namespace FactoryMethod.Pizzaria
{
    // Concrete Product
    class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            base.Nome = "Pizza de mussarela paulista";
            base.massa = "Massa fina crocante paulista";
            base.molho = "Molho de tomate italiano paulista";

            base.ingredientes.Add("Queijo parmmesão");
            base.ingredientes.Add("Azeitonas verdes");
        }
    }
}
