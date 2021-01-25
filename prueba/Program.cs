using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase pepe = new Clase("milo","paz","3131","26-11-93",true);
            console.writeline(pepe.BuscarAlumno("3131"));
        }
    }
}

