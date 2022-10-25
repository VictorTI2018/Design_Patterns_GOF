using GOF.Application.FactoryMethod.Filial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.FactoryMethod
{
    public class RJPizzaFactoryMethod : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            Pizza pizza = tipo switch
            {
                "M" => new RJPizzaMussarela(),
                "C" => new RJPizzaCalabresa(),
                _ => throw new ApplicationException("Pizza não criada!"),
            };
            return pizza;
        }
    }
}
