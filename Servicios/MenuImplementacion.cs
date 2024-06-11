using RepasoPuertos.Controlador;
using RepasoPuertos.Dto;

namespace RepasoPuertos.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        OperativaInterfaz oi = new OperativaImplementacion();

        private void ficheroLogger(string mensaje)
        {
            try
            {
                using (StreamWriter logWriter = new StreamWriter(Program.ficheroLog, true))
                {
                    logWriter.WriteLine(mensaje);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        public void MenuEeste()
        {
            try
            {
                int opcionSeleccionada;
                bool esCerrado = false;

                do
                {
                    opcionSeleccionada = MenuEsteMostrar();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            mensaje += "Volver";
                            esCerrado = true;
                            Console.WriteLine("Volver");
                            break;

                        case 1:
                            mensaje += "Mostrar lista este";
                            oi.MostrarListaEste();
                            break;
                        case 2:
                            mensaje += "Registro norte";
                            oi.RegistroEste();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    ficheroLogger(mensaje);
                } while (!esCerrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        private int MenuEsteMostrar()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Menu Puerta este");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Mostrar lista de vehiculos");
            Console.WriteLine("2.Registrar llegada de vehiculo");
            Console.WriteLine("---------------");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        public int MenuInicial()
        {
            Console.WriteLine("Menu Principal aduanas");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Puerta Sur");
            Console.WriteLine("2.Puerta Oeste");
            Console.WriteLine("3.Puerta Norte");
            Console.WriteLine("4.Puerta Este");
            Console.WriteLine("5.PIF");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        
        public void MenuNorte()
        {
            try
            {
                int opcionSeleccionada;
                bool esCerrado = false;

                do
                {
                    opcionSeleccionada = MenuNorteMostrar();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            mensaje += "Volver";
                            esCerrado = true;
                            Console.WriteLine("Volver");
                            break;

                        case 1:
                            mensaje += "Mostrar lista norte";
                            oi.MostrarListaNorte();
                            break;
                        case 2:
                            mensaje += "Registro norte";
                            oi.RegistroNorte();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    ficheroLogger(mensaje);
                } while (!esCerrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        private int MenuNorteMostrar()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Menu Puerta Oeste");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Mostrar lista de vehiculos");
            Console.WriteLine("2.Registrar llegada de vehiculo");
            Console.WriteLine("---------------");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        public void MenuOeste()
        {

            try
            {
                int opcionSeleccionada;
                bool esCerrado = false;

                do
                {
                    opcionSeleccionada = MenuOesteMostrar();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            mensaje += "Volver";
                            esCerrado = true;
                            Console.WriteLine("Volver");
                            break;

                        case 1:
                            mensaje += "Mostrar lista oeste";
                            oi.MostrarListaOeste();
                            break;
                        case 2:
                            mensaje += "Registro oeste";
                            oi.RegistroOeste();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    ficheroLogger(mensaje);
                } while (!esCerrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        private int MenuOesteMostrar()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Menu Puerta Oeste");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Mostrar lista de vehiculos");
            Console.WriteLine("2.Registrar llegada de vehiculo");
            Console.WriteLine("---------------");


            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        public void MenuSur()
        {
            try
            {
                int opcionSeleccionada;
                bool esCerrado = false;

                do
                {
                    opcionSeleccionada = MenuSurMostrar();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            mensaje += "Volver";
                            esCerrado = true;
                            Console.WriteLine("Volver");
                            break;

                        case 1:

                            mensaje += "Registro entrada Sur";
                            oi.RegistroSur();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    ficheroLogger(mensaje);
                } while (!esCerrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        private int MenuSurMostrar()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Menu Puerta Sur");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Registrar vehiculos");
            Console.WriteLine("---------------");


            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        public void PIF()
        {
            try
            {
                int opcionSeleccionada;
                bool esCerrado = false;

                do
                {
                    opcionSeleccionada = MenuPIFMostrar();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:

                            mensaje += "Volver";
                            esCerrado = true;
                            Console.WriteLine("Volver");
                            break;

                        case 1:
                            mensaje += "Mostrar lista Sur";
                            oi.MostrarListaPIF();
                            break;

                        case 2:
                            mensaje += "Registro entrada PIF";
                            oi.RegistroPIF();
                            break;

                        default:
                            mensaje += "Opcion incorrecta";
                            Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }
                    ficheroLogger(mensaje);
                } while (!esCerrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + ex.Message);
            }
        }

        private int MenuPIFMostrar()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Menu PIF");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Mostrar lista de vehiculos");
            Console.WriteLine("2.Registrar llegada de vehiculo");
            Console.WriteLine("---------------");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }
    }
}