// See https://aka.ms/new-console-template for more information


// Simple Factorey
//using GOF.Application.SimpleFactory;
//using GOF.Application.SimpleFactory.Classes;

//static void InitSimpleFactory ()
//{
//    Console.WriteLine("******************* Pizzaria *****************");
//    Console.WriteLine("Informe a pizza (C)alabresa / (M)ussarela ");
//    var pizzaEscolhida = Console.ReadLine().ToUpper();
//    Console.WriteLine(" ");
//    try
//    {
//        Pizza pizza = PizzaFactory.Criar(pizzaEscolhida);
//        pizza.Preparar();
//        pizza.Assar(40);
//        pizza.Embalar();
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine($"Error: {ex.Message}");
//    }

//    Console.ReadKey();
//}

//InitSimpleFactory();

using GOF.Application.FactoryMethod;

static void InitFactoryMethod()
{
    Console.WriteLine("******************* Pizzaria *****************");
    Console.WriteLine("Informe o local (SP) São Paulo / (RJ) Rio de Janeiro");
    var localEscolhido = Console.ReadLine().ToUpper();

    Console.WriteLine(" ");

    Console.WriteLine("Escolha a pizza (M)ussarela / (C)alabresa");
    var pizzaEscolhida = Console.ReadLine().ToUpper();
    Console.WriteLine(" ");
    try
    {
        PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
        var pizza = pizzaria.MontaPizza(pizzaEscolhida);
        Console.WriteLine(pizza.Preparar());
        Console.WriteLine("\nPizza concluida com sucesso");
    }catch(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    Console.ReadKey();
}

InitFactoryMethod();
