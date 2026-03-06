using System.Collections.Generic;
Dictionary<int, string> empleados = new Dictionary<int, string>();
string op;
do
{
    Console.WriteLine("Ingrese el ID del usuario");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Imgrese el nombre");
    string nombre = Console.ReadLine();
    empleados.Add(id, nombre);
    Console.WriteLine("Desea registrar otro usuario? (s/n)");
    op = Console.ReadLine();
} while (op != "n");
Console.Clear();
Console.WriteLine("Empleados registrados");
foreach(var emp in empleados)
{
    Console.WriteLine($"ID: {emp.Key} Nombre: {emp.Value}");
}