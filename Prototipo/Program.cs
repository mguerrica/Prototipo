using System;

namespace Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario.Login();

            /*static int MenuPrincipal(int opcion)
            {
                Console.WriteLine("Seleccione una opcion del menú: ");
                Console.WriteLine("[1] Solicitar servicio");
                Console.WriteLine("[2] Consultar estado de cuenta");
                Console.WriteLine("[3] Consultar seguimiento de pedido");
                Console.WriteLine("[4] Salir");
                return opcion;
            }*/


            bool flagV, flagN;

            do
            {
                Console.WriteLine("Bievenido, ingrese una opcion del menú: ");
                Console.WriteLine("[1] Solicitar servicio");
                Console.WriteLine("[2] Consultar estado de cuenta");
                Console.WriteLine("[3] Consultar seguimiento de pedido");
                Console.WriteLine("[4] Salir");
                string opcionUsuario = Console.ReadLine();
                int opcionUsuarioValidado = 0;

                flagV = ValidarVacio(opcionUsuario, "Menú de servicios");
                flagN = ValidarNumero(opcionUsuario, ref opcionUsuarioValidado);

            } while (flagV == false && flagN == false);



            static bool ValidarVacio(string ingreso, string campo)
            {
                bool flag = false;
                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("Usted ingresó un dato vacío en el campo " + campo);
                }
                else
                {
                    flag = true;
                }

                return flag;
            }



            static bool ValidarNumero(string numero, ref int numeroSalida)
            {
                bool flag = false;
                if (!int.TryParse(numero, out numeroSalida))
                {
                    Console.WriteLine("Opción invalida. Por favor ingrese el número del menú nuevamente");
                }
                else if (numeroSalida >= 6 || numeroSalida < 1)
                {
                    Console.WriteLine("Opción invalida. Por favor ingrese el número del menú nuevamente");
                }
                else
                {
                    flag = true;
                }
                return flag;

            }

        }

    }

} 
    

