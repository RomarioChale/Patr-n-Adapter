using Práctica_Converter.Services;
using System;

namespace Práctica_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSucursales sucursal = new ListaSucursales();
            ListaAJsonAdapter listaAJsonAdapter = new ListaAJsonAdapter(sucursal);
            listaAJsonAdapter.ConvertirListaAJson();
            Console.ReadLine();
        }
    }
}
