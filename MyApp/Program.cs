// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Text.Json;
using System.Text.Json.Serialization;



List<Producto> ListaDeProductos = new List<Producto>();

Random rand = new Random();
int cantProductos = rand.Next(1, 13);

string path  = "/Users/juanigramajo/Desktop/Fac/04. Segundo año/Primer Cuatrimestre/Taller de Lenguajes I/Trabajos Prácticos/tp09-2022-juanigramajo/MyApp";


if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}

if (!File.Exists(path + "/Productos.json"))
{
    File.Create(path + "/Productos.json");
} else
{
    File.Create(path + "/Productos.json").Close();
}


for (int i = 0; i < cantProductos; i++)
{
    Producto producto = new Producto();
    producto = producto.cargarProductos();

    ListaDeProductos.Add(producto);
}


string jsonString = JsonSerializer.Serialize(ListaDeProductos);
File.WriteAllText(path + "/Productos.json", jsonString);





List<Producto> ListadoDeProductosEnJson = new List<Producto>();

string productosEnJson = File.ReadAllText(path + "/Productos.json");


ListadoDeProductosEnJson = JsonSerializer.Deserialize<List<Producto>>(productosEnJson);


foreach (Producto productoX in ListadoDeProductosEnJson)
{
    productoX.mostrarDatos();
}