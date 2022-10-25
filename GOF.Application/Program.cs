// See https://aka.ms/new-console-template for more information


using GOF.Application.SimpleFactory;
using GOF.Application.SimpleFactory.Classes;

static void InitSimpleFactore ()
{
    Console.WriteLine("******************* Pizzaria *****************");
    Console.WriteLine("Informe a pizza (C)alabresa / (M)ussarela ");
    var pizzaEscolhida = Console.ReadLine().ToUpper();
    Console.WriteLine(" ");
    try
    {
        Pizza pizza = PizzaFactory.Criar(pizzaEscolhida);
        pizza.Preparar();
        pizza.Assar(40);
        pizza.Embalar();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.ReadKey();
}

InitSimpleFactore();

