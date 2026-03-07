using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
int op;
do
{
    Console.WriteLine("Binevenido al menu, seleccione la opcion que necesite");
    Console.WriteLine("1. Ingresar un producto");
    Console.WriteLine("2. Eliminar un producto por medio de su codigo");
    Console.WriteLine("3. Mostrar productos registrados");
    Console.WriteLine("4. Salir");
    op=int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            string opcion;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto");
                int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el producto");
                string productoing = Console.ReadLine();
                productos.Add(codigo, productoing);
                Console.WriteLine("Desea ingresar otro producto? (s/n)");
                opcion = Console.ReadLine();
            } while (opcion != "n");
            break;
            case 2:
            Console.WriteLine("Ingrese el codigo del producto que dese eliminar");
            int buscar = int.Parse(Console.ReadLine());
            if (productos.ContainsKey(buscar))
            {
                productos.Remove(buscar);
                Console.WriteLine("Producto eliminado correctamente");
            }
            else
            {
                Console.WriteLine("El codigo del producto que ingreso no se ha registrado");
            }
            break;
            
    }
} while (op!=4);