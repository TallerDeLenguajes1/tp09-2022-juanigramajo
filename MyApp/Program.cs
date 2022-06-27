// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Text.Json;
using System.Text.Json.Serialization;



List<string> ListaDeArchivos = new List<string>();

Console.WriteLine("\nIngrese el path de una carpeta a ser buscada: ");
string PathCarpeta = "/Users/juanigramajo/Desktop/Fac/04. Segundo año/Primer Cuatrimestre/Taller de Lenguajes I/Trabajos Prácticos/tp09-2022-juanigramajo/" + Console.ReadLine();

if (!(Directory.Exists(PathCarpeta)))
{
    Console.WriteLine("\nNo existe la carpeta. ¿Desea crearla?\nOPCIONES\n[S] Si\n[N] No\nIngrese una opción: ");
    char salida = Char.ToLower(Convert.ToChar(Console.ReadLine()));
    while ((salida != 's') && (salida != 'n'))
    {
        Console.WriteLine("\nError de formato.\nOPCIONES\n[S] Si\n[N] No\nIngrese una opción: ");
        salida = Char.ToLower(Convert.ToChar(Console.ReadLine()));
    }

    if (salida == 's')
    {
        Directory.CreateDirectory(PathCarpeta);
    }

} else
{
    ListaDeArchivos = Directory.GetFiles(PathCarpeta).ToList();
}

int bandera = 0;
List<CrearArchivo> archivos = new List<CrearArchivo>();

foreach (string fileX in ListaDeArchivos)
{
    Console.WriteLine(fileX);

    CrearArchivo archivoX = new CrearArchivo(bandera, Path.GetFileNameWithoutExtension(fileX), Path.GetExtension(fileX));
    bandera++;
    archivos.Add(archivoX);

}

string jsonString = JsonSerializer.Serialize(archivos);

File.AppendAllText(PathCarpeta + "/index.json", jsonString);