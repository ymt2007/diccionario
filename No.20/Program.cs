using System.Collections.Generic;
Dictionary < int, (string Nombre, int edad, string carrera) > estudiantes = new Dictionary<int, (string, int, string) > ();
for(int i=1;i<=3;i++)
{
    Console.WriteLine($"Ingrese el carne del estudiante {i}");
    int carne=int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese el nombre del estudiante {i}");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Ingrese la edad del estudiante {i}");
    int edad = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese la carrera que cursa el estudiante {i}");
    string carrera = Console.ReadLine();
    estudiantes.Add(carne,(nombre,edad,carrera));
}
Console.Clear ();
foreach(var est in estudiantes)
{
    Console.WriteLine(est);
}