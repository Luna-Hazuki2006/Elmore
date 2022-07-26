using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmore.Modelo
{
    public class Usuario
    {
        public string Nombre;
        public string NombreCompleto;
        public string Parroquia;
        public string Municipio;
        public string Ciudad;
        public string Estado;
        public string Direccion;
        public string Clave;
        public char Estatus;

        public override string ToString()
        {
            return Nombre.ToString();
        }
    }
}
