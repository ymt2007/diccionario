using System.Collections.Generic;
Dictionary<int, string> estudiantes = new Dictionary<int, string>();
int opcion;
string op;
do
{
    Console.WriteLine("Bienvenido al menu, seleccione la opcion deseada");
    Console.WriteLine("1. Registrar alumno");
    Console.WriteLine("2. Mostrar lista de alumnos registrados");
    Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese el ID del alumno");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del alumno");
                string nombre = Console.ReadLine();
                estudiantes.Add(id, nombre);
                Console.WriteLine("Desea registrar otro estudiante? (s/n)");
                op = Console.ReadLine();
            } while (op != "n");
            Console.Clear();
            break;
            case 2:
            foreach(var est in estudiantes)
            {
                Console.WriteLine(est);
            }
            break;
            
    }
} while (opcion != 3);