using System.Collections.Generic;
Dictionary<int, double> notas=new Dictionary<int, double>();
double suma;
Console.WriteLine("Cuantas notas desea ingresar?");
int ingreso=int.Parse(Console.ReadLine());
for(int i=1;i<=ingreso;i++)
{
    Console.WriteLine($"Ingrese la nota {i}");
    double notaing = double.Parse(Console.ReadLine());
    notas.Add(i, notaing);
}
