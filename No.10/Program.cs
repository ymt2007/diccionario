using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
string opcion;
do
{
    Console.WriteLine("Ingrese el codigo del producto");
    int codigo=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el producto");
    string productoing=Console.ReadLine();
    Console.WriteLine("Desea ingresar otro producto? (s/n)");
    opcion = Console.ReadLine();
} while (opcion != "n");