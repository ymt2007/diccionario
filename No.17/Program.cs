using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
int op;
do
{
    Console.WriteLine("Binevenido al menu, seleccione la opcion que necesite");
    Console.WriteLine("1. Ingresar un producto");
    Console.WriteLine("2. Eliminar un producto por medio de su codigo");
    Console.WriteLine("3. mostrar productos registrados");
    Console.WriteLine("4. Salir");
    op=int.Parse(Console.ReadLine());

} while (op!=4);