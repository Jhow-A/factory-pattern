namespace FactoryMethod.Pizzaria
{
    // Concrete Product
    class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            base.Nome = "Pizza de calabresa carioca com cebola";
            base.massa = "Massa tradicional carioca";
            base.molho = "Molho de tomate italiano carioca";

            base.ingredientes.Add("Fatias de calabresa especial");
            base.ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
