using System.Collections;
using System.Text;

namespace FactoryMethod.Pizzaria
{
    // Product
    public abstract class Pizza
    {
        protected string Nome { get; set; }

        protected string massa;
        protected string molho;
        protected ArrayList ingredientes = new ArrayList();

        public string Preparar()
        {
            var sb = new StringBuilder();
            sb.Append($"\nPreparando {Nome} \n");
            sb.Append($"{massa} \n");
            sb.Append($"{molho} \n");

            if (ingredientes.Count > 0)
                sb.Append($"Ingredientes: \n");

            foreach (var ingrediente in ingredientes)
                sb.Append($"\t {ingrediente} \n");

            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());

            return sb.ToString();
        }

        public virtual string Cozinhar() => "Cozinhando por 25 minutos a 350 graus \n";
        public virtual string Fatiar() => "Fatiando a pizza em 8 pedaços \n";
        public virtual string Embalar() => "Embalando a pizza \n";
    }
}
