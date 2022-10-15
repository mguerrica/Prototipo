using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    class Usuario
    {
        //LOGIN Funciona únicamente con usuario = asd y password = 123
        public static void Login()
        {
            string usuario, password;
            bool flag;
            while (true)
            {
                do
                {
                    Console.WriteLine("Ingrese usuario: ");
                    usuario = Console.ReadLine();
                    flag = ValidarVacio(usuario, "Usuario");
                } while (flag == false);
                do
                {
                    Console.WriteLine("Ingrese password: ");
                    password = Console.ReadLine();
                    flag = ValidarVacio(password, "password");
                } while (flag == false);

                if (usuario != "asd" || password != "123")
                {
                    Console.WriteLine("Opción no implementado.");
                }
                else
                {
                    Console.WriteLine("¡Acceso correcto!");
                    break;
                }
            }
        }

        public static int PedirEntero(string mensaje)
        {
            bool flag;
            int nroIngresado = 0;
            do
            {
                Console.WriteLine(mensaje);
                string ingreso = Console.ReadLine();
                flag = ValidarNumeroMenu(ingreso, ref nroIngresado);
            } while (flag == false);

            return nroIngresado;
        }

        private static bool ValidarVacio(string ingreso, string campo)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("Usted ingresó un dato vacío en " + campo);
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private static bool ValidarNumeroMenu(string numero, ref int numeroSalida)
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
