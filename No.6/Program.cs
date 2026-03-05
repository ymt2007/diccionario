using System.Collections.Generic;
Dictionary<int, string> estudiantes = new Dictionary<int, string>();
Console.WriteLine("Estudiantes registrados:");
estudiantes.Add(22010020, "Manuel");
estudiantes.Add(23453348, "Sandra");
estudiantes.Add(23764286, "Paco");

estudiantes.Remove(23764286);
foreach(var est in estudiantes)
{
    Console.WriteLine(est);
}
