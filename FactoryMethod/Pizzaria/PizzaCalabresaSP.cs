namespace FactoryMethod.Pizzaria
{
    // Concrete Product
    class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            base.Nome = "Pizza de calabresa paulista";
            base.massa = "Massa fina crocante paulista";
            base.molho = "Molho de tomate italiano paulista";

            base.ingredientes.Add("Fatias de calabresa defumada especial");
            base.ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
