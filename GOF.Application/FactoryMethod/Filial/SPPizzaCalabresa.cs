using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.FactoryMethod.Filial
{
    internal class SPPizzaCalabresa: Pizza
    {
        public SPPizzaCalabresa()
        {
            Nome = "Pizza de calabresa Paulista";
            massa = "Massa fina crocante";
            molho = "Moloho de tomate";
            ingredientes.Add("Fatias de calabresa defumada especial");
            ingredientes.Add("Queijo parmessão");
        }
    }
}
