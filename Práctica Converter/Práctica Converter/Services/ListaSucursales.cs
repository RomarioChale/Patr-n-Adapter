using Práctica_Converter.Entities;
using System.Collections.Generic;

namespace Práctica_Converter.Services
{
    public class ListaSucursales
    {
        public List<Sucursal> ListaSucursal()
        {
            Sucursal sucursal = new Sucursal()
            {
                Id = "Id",
                Nombre = "Nombre",
                Ventas = 10
            };

            return new List<Sucursal> {sucursal };

        }
    }
}
