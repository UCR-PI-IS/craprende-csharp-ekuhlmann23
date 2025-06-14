namespace CRAprende;

public class Profesor
{
    public string Nombre { get; set; }
    public int AniosExperiencia { get; set; }

    public Profesor(string nombre, int aniosExperiencia)
    {
        Nombre = nombre;
        AniosExperiencia = aniosExperiencia;
    }
}
