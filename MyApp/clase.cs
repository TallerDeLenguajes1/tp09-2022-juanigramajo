


public enum Nombres
{
    iPhone11,
    iPhone12,
    iPhone13,
    iPad9,
    iPadPro,
    iPadAir,
    MacBookPro,
    MacBookAir,
    AppleWatch
}

public enum Tamanos
{
    de128,
    de256,
    de512,
    de1024
}

public class Producto
{
    private string nombre;
    private DateTime fechaVencimiento;
    private float precio;
    string tamano;


    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamano { get => tamano; set => tamano = value; }


    public Producto cargarProductos()
    {
        Producto NProducto = new Producto();
        Random rand = new Random();


        NProducto.nombre = Enum.GetName(typeof(Nombres), rand.Next(1, Enum.GetNames(typeof(Nombres)).Length));
        NProducto.tamano = Enum.GetName(typeof(Tamanos), rand.Next(1, Enum.GetNames(typeof(Tamanos)).Length));

        NProducto.precio = rand.Next(1000, 5000);
        NProducto.FechaVencimiento = new DateTime(rand.Next(2022, 2051), rand.Next(1, 13),rand.Next(1, 32));


        return NProducto;
    }

    public void mostrarDatos()
    {   
        Console.WriteLine("\n-------------------------");
        Console.WriteLine("\nNombre: " + Nombre);
        Console.WriteLine("Fecha de vencimiento: " + FechaVencimiento.ToShortDateString());
        Console.WriteLine("Precio: $" + Precio);
        Console.WriteLine($"Tamaño: {Tamano} GB");
    } 
}
