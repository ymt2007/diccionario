using System.Collections.Generic;
Dictionary<string, double> notas = new Dictionary<string, double>();
string opcion;
do
{
    Console.WriteLine("Ingrese el nombre del estudiante");
    string nombre=Console.ReadLine();
    Console.WriteLine("Ingrese la nota del estudiante");
    double notaing=double.Parse(Console.ReadLine());
    Console.WriteLine("Desea ingresar otra nota? (s/n)");
    opcion=Console.ReadLine();
} while (opcion != "s");
Console.Clear();
Console.WriteLine("Ingrese el nombre del estudiante con la nota a buscar");
string buscar=Console.ReadLine();
