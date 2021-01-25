namespace prueba
{
public class Persona
{
    public string Nombre;
    public string Apellido;
    public string DNI;
    public string FechaNacimiento;
    public bool Activo {get;}

    public Persona()
    {}

    public Persona(string nombre, string apellido, string dni, string fechanacimiento, bool activo)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaNacimiento = fechanacimiento;
        Activo = activo;    
    }
        public void Activar()
        {
            Activo = true;
        }
        public void Inactivar()
        {
            Activo = false;
        }
} 
}

