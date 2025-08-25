// See https://aka.ms/new-console-template for more information

var estudiante = new Estudiantes();

estudiante.Id = 1;
estudiante.Nombre = "Juan Carlos";
estudiante.Carnet = 2411;

estudiante.Prestamos = new List<Libros>();
estudiante.Prestamos.Add(new Libros() { Id = 1, Titulo = "Ba", Autor= "ca", Disponible= true });
estudiante.Prestamos.Add(new Libros() { Id = 2, Titulo = "r", Autor = "di", Disponible = true });

Console.WriteLine("ID Estudiante: " + estudiante.Id);
Console.WriteLine("Nombre Estudiante: " + estudiante.Nombre);
Console.WriteLine("Nombre Estudiante: " + estudiante.Carnet);
foreach (Libros i in estudiante.Prestamos)
{
    Console.Write(i.Titulo);
    Console.Write(i.Autor);
}

public class Libros
{
    public int Id = 0;
    public String Titulo = "";
    public String Autor = "";
    public bool Disponible = false;
}

public class Personas
{
    public int Id = 0;
    public String Nombre = "";
}

public class Estudiantes : Personas
{
    public int Carnet = 0;
    public List<Libros> Prestamos = new List<Libros>();
}

