using System.Collections.Generic;
Dictionary<int, string> ciudades= new Dictionary<int, string>();
ciudades.Add(1234, "Mexico");
ciudades.Add(5679, "Guatemala");
ciudades.Add(9384, "Japon");
ciudades.Add(2839, "Honduras");
ciudades.Add(2837, "Portugal");
foreach(var ciu in ciudades)
{
    Console.Write($"{ciu.Key}, ");
}