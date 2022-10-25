using GOF.Application.FactoryMethod.Filial;

namespace GOF.Application.FactoryMethod
{
    public class SPPizzaFactoryMethod : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            Pizza pizza = tipo switch
            {
                "M" => new SPPizzaMussarela(),
                "C" => new SPPizzaCalabresa(),
                _ => throw new ApplicationException("Pizza não criada!"),
            };
            return pizza;
        }
    }
}
