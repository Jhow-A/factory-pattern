namespace AbstractFactory.Domain.Products.Pizza
{
    // Product B1
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base("Pizza Calabresa", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabresa em cubos e tomates em cubos");
        }
    }
}
