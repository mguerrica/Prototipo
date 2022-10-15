using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    internal static class MenuPrincipal
    {
        internal static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Bievenido, ingrese una opcion del menú: ");
            Console.WriteLine("[1] Solicitar servicio");
            Console.WriteLine("[2] Consultar estado de cuenta");
            Console.WriteLine("[3] Consultar seguimiento de pedido");
            Console.WriteLine("[4] Salir");

            do
            {
                var opcion = Usuario.PedirEntero("Ingrese su opción: ");
                /*if (opcion == 1)
                {
                    IngresoServicioCorporativo.Iniciar();
                }
                else if(opcion == 2)
                {
                    ConsultarEstadoCuenta.Iniciar();
                }
                else if(opcion == 3)
                {
                    ConsultarSeguimientoPedido.Iniciar();
                }
                else if(opcion == 4)
                {
                    //Salir
                }*/


            } while (opcion != 4);
        }
    }
}
