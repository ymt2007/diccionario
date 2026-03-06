using System.Collections.Generic;
Dictionary<string, double> notas = new Dictionary<string, double>();
string opcion, nombre, op;
double notaing;
do
{
    Console.WriteLine("Ingrese el nombre del estudiante");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la nota del estudiante");
     notaing = int.Parse(Console.ReadLine());
    notas.Add(nombre, notaing);
    Console.WriteLine("Desea ingresar otro estudiante? (s/n)");
    opcion = Console.ReadLine();
} while (opcion != "n");
Console.Clear();
do
{
    Console.WriteLine("Ingrese el nombre del estudiante del cual desea saber la nota");
    string buscar = Console.ReadLine();
    if (notas.ContainsKey(buscar))
    {
        Console.WriteLine($"La nota del estudiante {buscar} es: {notas[buscar]}");
    }
    else
    {
        Console.WriteLine("No se ha registrado a ningun estudiante con ese nombre");
    }
    Console.WriteLine("Desea saber la nota de otro estudiante? (s/n)");
    op= Console.ReadLine();
} while (op!="n");