using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public Estudiante(string nombre, string apellido, string email, string telefono, int edad)
            : base(nombre, apellido, email, telefono, edad) { }
    }
}
