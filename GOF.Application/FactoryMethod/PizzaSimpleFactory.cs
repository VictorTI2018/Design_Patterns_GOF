using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria = local switch
            {
                "SP" => new SPPizzaFactoryMethod(),
                "RJ" => new RJPizzaFactoryMethod(),
                _ => throw new ApplicationException($"A pizzaria {local} não foi criada")
            };

            return pizzaria;
        }
    }
}
