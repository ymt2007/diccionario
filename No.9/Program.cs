using System.Collections.Generic;
Dictionary<string, double> notas = new Dictionary<string, double>();
string opcion, nombre;
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
