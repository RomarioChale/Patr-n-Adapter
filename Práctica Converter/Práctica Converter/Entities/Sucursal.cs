using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_Converter.Entities
{
    public class Sucursal
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Ventas { get; set; }

        public Sucursal() { }
        public Sucursal(string id, string nombre, int ventas)
        {
            Id = id;
            Nombre = nombre;
            Ventas = ventas;
        }
    }
}
