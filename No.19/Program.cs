using System.Collections.Generic;
Dictionary<string, double> notas = new Dictionary<string, double>();
int opcion;
do
{
    Console.WriteLine("Bienvenido al menu, seleccione la opcion deseada");
    Console.WriteLine("1. Ingresar notas");
    Console.WriteLine("2. Modificar notas");
    Console.WriteLine("3. Mostrar notas");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());
    string op1;
    switch(opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante");
                double notaing = double.Parse(Console.ReadLine());
                notas.Add(nombre, notaing);
                Console.WriteLine("Desea registrar la nota de otro estudiante (s/n)");
                op1=Console.ReadLine();
            } while (op1!="n");
            break;
            case 2:
            string op2;
            do
            {
                Console.WriteLine("Ingrese el nombre del estudiante del cual desea modificar las notas");
                string notamod = Console.ReadLine();
                Console.WriteLine("Ingrese la nueva nota");
                double notanueva= double.Parse(Console.ReadLine());
                notas[notamod] = notanueva;
                Console.WriteLine("Desea modificar la nota de otro estudiante? (s/n)");
                op2 = Console.ReadLine();
            } while (op2 != "n");
            break;
    }
} while (opcion!=4);