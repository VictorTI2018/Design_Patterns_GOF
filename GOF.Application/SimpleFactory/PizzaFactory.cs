using GOF.Application.SimpleFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.SimpleFactory
{
    internal class PizzaFactory
    {

        public static Pizza Criar (string nomePizza)
        {
            Pizza pizza;
            switch(nomePizza)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza {nomePizza} não foi criada!");
            }

            return pizza;
        }
    }
}
