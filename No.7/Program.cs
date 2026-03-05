using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
string opcion;
do
{
    Console.WriteLine("Ingrese el codigo del producto");
    int codigo=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el producto");
    string productoing=Console.ReadLine();
    if(productos.ContainsKey(codigo))
    {
        Console.WriteLine("Error, el codigo del producto que ingreso ya existe, no se registrara el producto que acaba de ingresar");
    }
    else
    {
        productos.Add(codigo, productoing);
    }
    Console.WriteLine("Desea ingresar otro producto? (s/n)");
    opcion = Console.ReadLine();
} while (opcion != "n");
Console.WriteLine("Productos registrados");
Console.Clear();
foreach(var pros in productos)
{
    Console.WriteLine(pros);
}