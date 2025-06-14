using System.Collections.Generic;

namespace CRAprende;

public class ServicioDirectorioProfesores
{
    private List<Profesor> _profesores;

    public ServicioDirectorioProfesores()
    {
        // Inicializamos con algunos datos de ejemplo
        _profesores = new List<Profesor>
        {
            new Profesor("Dr. Alan Turing", 15),
            new Profesor("Dra. Ada Lovelace", 12),
            new Profesor("Dr. Edsger Dijkstra", 20),
            new Profesor("Dra. Grace Hopper", 18)
        };
    }

    public List<Profesor> ObtenerTodosLosProfesores()
    {
        return _profesores;
    }

    // Opcionalmente, podríamos añadir un método para agregar nuevos profesores
    public void AgregarProfesor(Profesor profesor)
    {
        _profesores.Add(profesor);
    }
}
