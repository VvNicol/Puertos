using RepasoPuertos.Controlador;
using RepasoPuertos.Dto;

namespace RepasoPuertos.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void MostrarListaEste()
        {
            Utils.Utils.MostrarListaPuertaEste();
        }

        public void MostrarListaNorte()
        {
            Utils.Utils.MostrarListaPuertaNorte();
        }

        public void MostrarListaOeste()
        {
            Utils.Utils.MostrarListaPuertaOeste();
        }

        public void MostrarListaPIF()
        {
            Utils.Utils.MostrarListaPIF();
        }

        public void RegistroEste()
        {
            try
            {
                Console.WriteLine("Ingrese la matricula");
                string matriVerificar = Console.ReadLine();
                bool esRegistrado = false;
                foreach (VehiculoDto registro in Program.vehiculoLista)
                {
                    if (registro.EsPuertaEste && registro.Matricula.Equals(matriVerificar))
                    {
                        esRegistrado = true;
                        registro.EsPuertaPIF = true;
                        registro.EsPuertaEste = false;
                        registro.FechaPuertaEste = DateTime.Now;
                        Console.WriteLine("Se registró correctamente");

                        return;
                    }
                }
                if (!esRegistrado)
                {
                    Console.WriteLine("La matrícula no existe en la zona este");
                }
            }
            catch (Exception io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }

        public void RegistroNorte()
        {
            try
            {
                Console.WriteLine("Ingrese la matricula");
                string matriVerificar = Console.ReadLine();
                bool esRegistrado = false;

                foreach (VehiculoDto registro in Program.vehiculoLista)
                {
                    if (registro.EsPuertaNorte && registro.Matricula.Equals(matriVerificar))
                    {
                        esRegistrado = true;
                        registro.FechaPuertaNorte = DateTime.Now;
                        Console.WriteLine("Se registró correctamente");

                        return;
                    }
                }
                if (!esRegistrado)
                {
                    Console.WriteLine("La matrícula no existe en la zona norte");
                }
            }
            catch (Exception io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }

        public void RegistroOeste()
        {
            try
            {
                Console.WriteLine("Ingrese la matricula");
                string matriVerificar = Console.ReadLine();
                bool esRegistrado = false;
                foreach (VehiculoDto registro in Program.vehiculoLista)
                {
                    if (registro.EsPuertaOste && registro.Matricula.Equals(matriVerificar))
                    {
                        esRegistrado = true;
                        registro.FechaPuertaOeste = DateTime.Now;
                        Console.WriteLine("Se registró correctamente");
                        return;
                    }
                }
                if (!esRegistrado)
                {
                    Console.WriteLine("La matrícula no existe en la zona oeste");
                }
            }
            catch (Exception io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }

        public void RegistroPIF()
        {
            try
            {
                Console.WriteLine("Ingrese la matricula");
                string matriVerificar = Console.ReadLine();
                bool matriculaEncontrada = false;

                foreach (VehiculoDto registro in Program.vehiculoLista)
                {
                    if (registro.Matricula.Equals(matriVerificar) && registro.EsPuertaPIF)
                    {
                        matriculaEncontrada = true;
                        Console.WriteLine("Es apta la mercancia? (s/n)");
                        char snApto = char.Parse(Console.ReadLine().ToLower());

                        if (snApto == 's')
                        {
                            registro.EsPuertaPIF = false;
                            registro.MercanciaApta = true;
                            registro.EsPuertaNorte = true;

                            Console.WriteLine("Dirigase a la puerta Norte");
                        }
                        else
                        {
                            registro.EsPuertaPIF = false;
                            registro.MercanciaApta = false;
                            registro.EsPuertaSur = true;

                            Console.WriteLine("Dirigase a la puerta sur");
                        }

                        registro.FechaPuertaEste = DateTime.Now;
                        return; // Salir del método después de registrar
                    }
                }

                if (!matriculaEncontrada)
                {
                    Console.WriteLine("La matrícula no existe en la zona PIF");
                }
            }
            catch (Exception io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }


        public void RegistroSur()
        {
            try
            {

                Console.WriteLine("Registro de vehiculo");
                Console.WriteLine("----------------------");
                Console.WriteLine("Ingrese la matricula");
                string matriculaRegistro = Console.ReadLine();
                Console.WriteLine("Tipo de vehiculo (P,F,A)");
                char tipoVehiculoRegistro = char.Parse(Console.ReadLine().ToUpper());
                bool esPuertaSur = true;
                Console.WriteLine("¿Lleva mercancia? s/n");
                char snRegistroMercancia = char.Parse(Console.ReadLine().ToLower());

                bool esMercancia = false;

                if (snRegistroMercancia == 's')
                {
                    esMercancia = true;
                }
                else
                {
                    esMercancia = false;
                }

                DateTime Registro = DateTime.Now;
                VehiculoDto nuevoVehiculo = new VehiculoDto(matriculaRegistro, tipoVehiculoRegistro, esPuertaSur, esMercancia, Registro);
                Utils.Utils.ZonaDestino(new List<VehiculoDto> { nuevoVehiculo }, esPuertaSur, esMercancia);


                Program.vehiculoLista.Add(nuevoVehiculo);
            }
            catch (Exception io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }
    }
}