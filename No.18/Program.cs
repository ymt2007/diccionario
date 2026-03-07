using System.Collections.Generic;
Dictionary<string, string> usuarios = new Dictionary<string, string>();
string opcion;
do
{
    Console.WriteLine("Ingrese el usuario");
    string usuarioin = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña");
    string contra= Console.ReadLine();
    if(usuarios.ContainsKey(usuarioin))
    {
        Console.WriteLine("El usuario ya existe, intento de nuevo");
    }
    else
    {
        usuarios.Add(usuarioin, contra);
        Console.WriteLine("Usuario registrado con exito");
    }
    Console.WriteLine("Desea registrar otro usuario? (s/n)");
    opcion = Console.ReadLine();
} while (opcion!="n");