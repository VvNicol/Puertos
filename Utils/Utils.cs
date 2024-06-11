using RepasoPuertos.Controlador;
using RepasoPuertos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPuertos.Utils
{
    internal class Utils
    {
        public static void ZonaDestino(List<VehiculoDto> vehiculoDtos, bool esPuertaSur, bool esMercancia)
        {
            foreach (VehiculoDto zonaDto in vehiculoDtos)
            {
                if (zonaDto.LlevaMercancia == false && zonaDto.VehiculoTipo.Equals('P'))
                {
                    zonaDto.EsPuertaSur = false;
                    zonaDto.EsPuertaOste = true;
                    Console.WriteLine("Dirigase a Zona Oeste");

                }
                else if (zonaDto.VehiculoTipo.Equals('F') || zonaDto.VehiculoTipo.Equals('A'))
                {

                    if (esMercancia == true)
                    {
                        zonaDto.EsPuertaEste = true;
                        zonaDto.EsPuertaSur = false;
                        Console.WriteLine("Dirigase a Zona Este ");

                    }
                    else if (esMercancia == false)
                    {
                        zonaDto.EsPuertaSur = false;
                        zonaDto.EsPuertaNorte = true;
                        Console.WriteLine("Dirigirse Zona Norte ");
                    }
                }
            }
        }
        public static void MostrarListaPuertaOeste()
        {
            var vehiculosPuertaOeste = Program.vehiculoLista.Where(v => v.EsPuertaOste).ToList();
            vehiculosPuertaOeste = vehiculosPuertaOeste.OrderBy(v => v.EsPuertaOste).ToList();

            if (vehiculosPuertaOeste.Count > 0) // Verificamos la cantidad de vehículos en la lista filtrada
            {
                foreach (VehiculoDto oeste in vehiculosPuertaOeste) // Iteramos sobre la lista filtrada
                {
                    Console.WriteLine($"Matricula: {oeste.Matricula}, Tipo: {oeste.VehiculoTipo}");
                }
            }
            else
            {
                Console.WriteLine("No hay nadie en la puerta Oeste");
            }
        }

        public static void MostrarListaPuertaEste()
        {
            var vehiculosPuertaEste = Program.vehiculoLista.Where(v => v.EsPuertaEste).ToList();
            vehiculosPuertaEste = vehiculosPuertaEste.OrderBy(v => v.EsPuertaEste).ToList();

            if (vehiculosPuertaEste.Count > 0)
            {
                foreach (VehiculoDto este in vehiculosPuertaEste)
                {
                    Console.WriteLine($"Matricula: {este.Matricula}, Tipo: {este.VehiculoTipo}");
                }
            }
            else
            {
                Console.WriteLine("No hay nadie en la puerta Este");
            }
        }

        public static void MostrarListaPuertaNorte()
        {
            var vehiculosPuertaNorte = Program.vehiculoLista.Where(v => v.EsPuertaNorte).ToList();
            vehiculosPuertaNorte = vehiculosPuertaNorte.OrderBy(v => v.EsPuertaNorte).ToList();

            if (vehiculosPuertaNorte.Count > 0)
            {
                foreach (VehiculoDto norte in vehiculosPuertaNorte)
                {
                    Console.WriteLine($"Matricula: {norte.Matricula}, Tipo: {norte.VehiculoTipo}");
                }
            }
            else
            {
                Console.WriteLine("No hay nadie en la puerta Norte");
            }
        }

        public static void MostrarListaPIF()
        {
            var vehiculosPIF = Program.vehiculoLista.Where(v => v.EsPuertaPIF).ToList();
            vehiculosPIF = vehiculosPIF.OrderBy(v => v.EsPuertaPIF).ToList();

            if (vehiculosPIF.Count > 0)
            {
                foreach (VehiculoDto pif in vehiculosPIF)
                {
                    Console.WriteLine($"Matricula: {pif.Matricula}, Tipo: {pif.VehiculoTipo}");
                }
            }
            else
            {
                Console.WriteLine("No hay nadie en la puerta PIF");
            }
        }

    }
}
