using System.Collections.Generic;

namespace prueba
{
public class Clase
{
    public List<Profesor> profesores  = new List<Profesor>();
    public List<Alumno> alumnos = new List<Alumno>();

    public void AgregarProfesor(Profesor prof)
    {
        profesores.Add(prof);
    }
    public void AgregarAlumno(Alumno alum)
    {
        alumnos.Add(alum);
    }
    public void BuscarAlumno(string dni)
    {
        foreach(var alumno in alumnos)
        {
            if (alumno.DNI == dni)
            {
                console.writeline("{0} existe",alumno.nombre);
            }
        }
    }
}
}
