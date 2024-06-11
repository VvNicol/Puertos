using RepasoPuertos.Dto;
using RepasoPuertos.Servicios;
using System.Diagnostics;

namespace RepasoPuertos.Controlador
{
    internal class Program
    {
        //Lista
        public static List<VehiculoDto> vehiculoLista = new List<VehiculoDto>();
        //Para el fichero
        public static DateTime fechaActual = DateTime.Today;
        public static string ficheroLog = $"{fechaActual.ToString("dd-MM-yyyy")} ficheroLog.txt";
        public static string informe = $"{fechaActual.ToString("dd-MM-yyyy")} informe.txt";
        static void Main(string[] args)
        {
            MenuInterface mi = new MenuImplementacion();
            int opcionSeleccionada;
            bool esCerrado = false;

            try
            {
                do
                {
                    opcionSeleccionada = mi.MenuInicial();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("¿Desea guardar los cambios? (s/n)");
                            char sn = Convert.ToChar(Console.ReadLine());

                            if (sn == 's')
                            {
                                // Se crea o abre el archivo en modo de anexión
                                using (StreamWriter sw = new StreamWriter(informe, true))
                                {
                                    // Si el archivo está vacío, se escribe el encabezado
                                    if (sw.BaseStream.Length == 0)
                                    {
                                        sw.WriteLine("Matricula;Tipo;Mercancia;Apta;fechaPuertaSur;fechaPuertaNorte;fechaPuertaOeste;fechaPuertaEste\n");
                                    }

                                    foreach (VehiculoDto var in vehiculoLista)
                                    {
                                        sw.WriteLine($"{var.Matricula};{var.VehiculoTipo};{var.LlevaMercancia};{var.MercanciaApta};{var.FechaPuertaSur};{var.FechaPuertaNorte};{var.FechaPuertaOeste};{var.FechaPuertaEste}\n");
                                    }
                                }

                                Console.WriteLine("Cambios guardados correctamente en el archivo.");
                            }
                            else
                            {
                                // No guardar los cambios si el usuario responde "n"
                                Console.WriteLine("Cambios no guardados.");
                            }
                            mensaje += "Aplicacion Cerrada";
                            esCerrado = true;
                            Console.WriteLine("Se ha cerrado la aplicacion");
                            break;

                        case 1:
                            mensaje += "Menu Sur";
                            mi.MenuSur();
                            break;
                        case 2:
                            mensaje += "Menu oeste";
                            mi.MenuOeste();
                            break;
                        case 3:
                            mensaje += "Menu norte";
                            mi.MenuNorte();
                            break;
                        case 4:
                            mensaje += "Menu Oeste";
                            mi.MenuEeste();
                            break;
                        case 5:
                            mensaje += "PIF";
                            mi.PIF();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    FicheroLogger(mensaje);
                } while (!esCerrado);

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }
        private static void FicheroLogger(string mensaje)
        {
            try
            {
                using (StreamWriter logWriter = new StreamWriter(ficheroLog, true))
                {
                    logWriter.WriteLine(mensaje);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }
    }
}
