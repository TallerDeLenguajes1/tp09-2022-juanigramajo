

public class CrearArchivo
{
    private int id;
    private string nombre;
    private string extension;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Extension { get => extension; set => extension = value; }


    public CrearArchivo(int ID, string NOMB, string EXT)
    {
        Id = ID;
        Nombre = NOMB;
        Extension = EXT;
    }
}