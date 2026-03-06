using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
string opcion, op1;
do
{
    Console.WriteLine("Ingrese el codigo del producto");
    int codigo=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el producto");
    string productoing=Console.ReadLine();
    productos.Add(codigo, productoing);
    Console.WriteLine("Desea ingresar otro producto? (s/n)");
    opcion = Console.ReadLine();
} while (opcion != "n");
Console.Clear();
do
{
    Console.WriteLine("Desea eliminar un producto por medio de su codigo? (s/n)");
    op1 = Console.ReadLine();
    if(op1=="s")
    {
        Console.WriteLine("Ingrese el codigo del producto que dese eliminar");
        int buscar=int.Parse(Console.ReadLine());   
        if(productos.ContainsKey(buscar))
        {
            productos.Remove(buscar);
            Console.WriteLine("Producto eliminado correctamente");
        }
        else
        {
            Console.WriteLine("El codigo del producto que ingreso no se ha registrado");
        }
    }
} while (op1!="n");
Console.Clear();
Console.WriteLine("Productos que se han registrado:");
foreach(var pros in productos)
{
    Console.WriteLine(pros);
}