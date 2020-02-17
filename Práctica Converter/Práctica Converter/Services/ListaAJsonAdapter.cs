using Newtonsoft.Json;
using Práctica_Converter.Entities;
using Práctica_Converter.Interfaces;
using System;
using System.Collections.Generic;

namespace Práctica_Converter.Services
{
    public class ListaAJsonAdapter : IConvertidorListaAJson
    {
        private readonly ListaSucursales _listaSucursales;
        public ListaAJsonAdapter(ListaSucursales listaSucursales)
        {
            _listaSucursales = listaSucursales;        }

        public void ConvertirListaAJson()
        {
            List<Sucursal> sucursales = _listaSucursales.ListaSucursal();

            string json = "";
            foreach (Sucursal sucursal in sucursales)
            {
                json = JsonConvert.SerializeObject(sucursal, Formatting.Indented);
            }

            Console.WriteLine(json);
        }
    }
}
