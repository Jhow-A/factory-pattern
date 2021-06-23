namespace FactoryMethod.Pizzaria
{
    // Concrete Product
    class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            base.Nome = "Pizza de mussarela carioca";
            base.massa = "Massa fina crocante carioca";
            base.molho = "Molho de tomate italiano carioca";

            base.ingredientes.Add("Queijo parmmesão ralado");
            base.ingredientes.Add("Azeitonas pretas");
        }
    }
}
