Dictionary<int, string> nombre = new Dictionary<int, string>();
for(int i=0; i<=3;i++)
{
    Console.WriteLine("Ingrese el ID");
    int id=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre de la persona");
    string nombreag=Console.ReadLine();
    nombre.Add(id, nombreag);
}
Console.WriteLine("Ingrese el ID de la persona que desea buscar");
int buscar=int.Parse(Console.ReadLine());
if(nombre.ContainsKey(buscar))
{
    Console.WriteLine($"El ID {buscar} es de {nombre.ContainsKey(buscar)}");
}
else
{
    Console.WriteLine("No registrado");
}
