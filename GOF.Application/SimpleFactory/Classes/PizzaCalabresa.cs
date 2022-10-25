using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Application.SimpleFactory.Classes
{
    internal class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Calabresa";
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min. ");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando Pizza de {Nome}");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando Pizza de {Nome}");
        }
    }
}
