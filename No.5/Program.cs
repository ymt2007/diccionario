using System;
using System.Collections.Generic;
Dictionary<string, string> usuarios = new Dictionary<string, string>();
string opcion;
do
{
    Console.WriteLine("Ingrese el usuario");
    string usuarioing = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña");
    string contrase = Console.ReadLine();
    Console.WriteLine("Desea ingresar otro usuario? (s/n)");
    opcion = Console.ReadLine();
    usuarios.Add(usuarioing, contrase);
} while (opcion != "n");
Console.Clear();
string op;
do
{
    Console.WriteLine("Ingrese el usuario del cual desea ver la contraseña");
    string buscar = Console.ReadLine(); 
    if(usuarios.ContainsKey(buscar))
    {
        Console.WriteLine($"La contraseña del usuario {buscar} es: {usuarios[buscar]}");
    }
    else
    {
        Console.WriteLine("Error, Usuario no registrado");
    }
    Console.WriteLine("Desea verificar la contraseña de otro usuario? (s/n)");
    op = Console.ReadLine();
} while (op != "n");
