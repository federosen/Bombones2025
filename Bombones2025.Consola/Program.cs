// See https://aka.ms/new-console-template for more information
using Bombones2025.Entidades;
using Bombones2025.Servicios;

while (true)
{
    Console.Clear();
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("1. Listar Paises");
    Console.WriteLine("2. Listar Frutos secos");

    Console.Write("Ingrese una opcion: ");

    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            ListarPaises();
            break;
        case "2":
            ListarFrutosSecos();
            break;
        default:
            break;
    }
}

void ListarFrutosSecos()
{
    Console.WriteLine("Hello, FrutoSecos");
    var frutoSecoServicio = new FrutoSecoServicio("FrutoSecos.txt");
    List<FrutoSeco> frutoSecos = frutoSecoServicio.GetFrutoSeco();
    foreach (FrutoSeco frutoSeco in frutoSecos)
    {
        Console.WriteLine(frutoSeco.ToString());
    }
    Console.ReadLine();
}

void ListarPaises()
{
    Console.WriteLine("Hello, Paises");
    var paisesServicio = new PaisServicio("Paises.txt");
    List<Pais> paises = paisesServicio.GetPaises();
    foreach (Pais pais in paises)
    {
        Console.WriteLine(pais.ToString());
    }
    Console.ReadLine();
}

//Console.WriteLine("Hello, Paises");
//var paisesServicio = new PaisServicio("Paises.txt");
//List<Pais> paises = paisesServicio.GetPaises();
//foreach (Pais pais in paises)
//{
//    Console.WriteLine(pais.ToString());
//}
//Console.ReadLine();

//Console.WriteLine("Hello, FrutoSecos");
//var frutoSecoServicio = new FrutoSecoServicio("FrutoSecos.txt");
//List<FrutoSeco> frutoSecos = frutoSecoServicio.GetFrutoSeco();
//foreach (FrutoSeco frutoSeco in frutoSecos)
//{
//    Console.WriteLine(frutoSeco.ToString());
//}
//Console.ReadLine();
