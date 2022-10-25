using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.FactoryMethod.Filial
{
    internal class SPPizzaMussarela: Pizza
    {
        public SPPizzaMussarela()
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante";
            molho = "Moloho de tomate";
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
