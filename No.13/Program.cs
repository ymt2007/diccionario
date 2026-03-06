using System.Collections.Generic;
Dictionary<int, double> notas=new Dictionary<int, double>();
Console.WriteLine("Cuantas notas desea ingresar?");
int ingreso=int.Parse(Console.ReadLine());
for(int i=1;i<=ingreso;i++)
{
    Console.WriteLine($"Ingrese la nota {i}");
    double notaing = double.Parse(Console.ReadLine());
    notas.Add(i, notaing);
}
Console.Clear();
double suma=0;
foreach (var not in notas)
{
    suma += not.Value;
}
double prom = suma / notas.Count;
Console.WriteLine($"El promedio es: {prom} ");
