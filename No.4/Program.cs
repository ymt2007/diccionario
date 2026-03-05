using System.Collections.Generic;
Dictionary<int, string> ciudades = new Dictionary<int, string>();
for(int i=1; i<=5;i++)
{
    Console.WriteLine("Ingrese el codigo de la ciudad");
    int codigo=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la ciudad");
    string ciudading=Console.ReadLine();
    ciudades.Add(codigo,ciudading);
}
Console.Clear();
string op;
do
{
    Console.WriteLine("Ingrese el codigo de la ciudad a buscar");
    int buscar=int.Parse(Console.ReadLine());
    if(ciudades.ContainsKey(buscar))
    {
        Console.WriteLine($"La ciudad con el codigo {buscar} es: {ciudades[buscar]}");
    }
    else
    {
        Console.WriteLine("No existe ciudad registrada con el codigo ingresado");
    }
    Console.WriteLine("Desea buscar otra ciudad? (s/n)");
    op=Console.ReadLine();
} while (op != "n");