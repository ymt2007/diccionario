using System.Collections.Generic;
Dictionary<string, double> notas = new Dictionary<string, double>();
string opcion;
do
{
    Console.WriteLine("Ingrese el nombre del estudiante");
    string nombre=Console.ReadLine();
    Console.WriteLine("Ingrese la nota del estudiante");
    double notaing=double.Parse(Console.ReadLine());
    notas.Add(nombre,notaing);
    Console.WriteLine("Desea ingresar otra nota? (s/n)");
    opcion=Console.ReadLine();
} while (opcion != "n");
Console.Clear();
string op;
do
{
    Console.WriteLine("Ingrese el nombre del estudiante con la nota a buscar");
    string buscar = Console.ReadLine();
    if (notas.ContainsKey(buscar))
    {
        Console.WriteLine($"La nota de {buscar} es: {notas[buscar]}");
    }
    else
    {
        Console.WriteLine("No se ha registrado notas a ese nombre");
    }
    Console.WriteLine("Desea buscar otra nota? (s/n)");
    op=Console.ReadLine();
} while (op != "n");