using AbstractFactory.Domain.Enums;
using System.Collections;

namespace AbstractFactory.Domain.Products
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }

        public ArrayList Ingredientes = new ArrayList();

        protected MassaBase(string nome, TipoMassa tipoMassa)
        {
            Nome = nome;
            TipoMassa = tipoMassa;
        }

        public override string ToString() => @$"
                Tipo: {TipoMassa}
                Nome: {Nome}
                Ingredientes: {Ingredientes[0]}";
    }
}
