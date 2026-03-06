using System.Collections.Generic;
Dictionary<int, string> empleados = new Dictionary<int, string>();
empleados.Add(123, "Juan");
empleados.Add(456, "Lupe");
empleados.Add(789, "Maria");
empleados.Add(101, "Antonia");

empleados[123] = "Pablo";
Console.WriteLine("Lista de empleados con el nombre modificado");
foreach(var emp in empleados)
{
    Console.WriteLine(emp);
}