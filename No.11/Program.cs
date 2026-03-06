using System.Collections.Generic;
Dictionary<int, string> estudiantes = new Dictionary<int, string>();
estudiantes.Add(123, "Roberto");
estudiantes.Add(456, "Maria");
estudiantes.Add(789, "katerin");
estudiantes.Add(101, "Alejandra");
estudiantes.Add(121, "Edgar");
Console.WriteLine("Estudiantes registrados con su respectivo numero de carne");
foreach(var item in estudiantes)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}