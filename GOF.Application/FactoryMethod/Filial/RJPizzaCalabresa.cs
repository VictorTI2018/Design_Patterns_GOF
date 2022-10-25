using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.FactoryMethod.Filial
{
    internal class RJPizzaCalabresa: Pizza
    {
        public RJPizzaCalabresa()
        {
            Nome = "Pizza de calabresa Carioca com cebola";
            massa = "Massa fina crocante";
            molho = "Moloho de tomate";
            ingredientes.Add("Fatias de calabresa defumada especial");
            ingredientes.Add("Queijo parmessão");
        }
    }
}
