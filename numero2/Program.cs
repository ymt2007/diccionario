using System.Collections.Generic;
Dictionary<int, string> productos = new Dictionary<int, string>();
productos.Add(789456, "Pan");
productos.Add(123546, "Jamon");
productos.Add(456852, "Queso");
foreach (var item in productos)
{
    Console.WriteLine(item);
}
