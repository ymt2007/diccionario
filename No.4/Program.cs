using System.Collections.Generic;
Dictionary<int, string> ciudades = new Dictionary<int, string>();
for(int i=1; i<=5;i++)
{
    Console.WriteLine("Ingrese el codigo de la ciudad");
    int codigo=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la ciudad");
    string ciudading=Console.ReadLine();
    ciudades.Add(codigo,ciudading);
}