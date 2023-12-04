using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_jpribui.Servicios
{
    /// <summary>
    /// Implementacion donde esta la logica de interaccion con el usuario 
    /// <author>jpr-04/12/23</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            Console.WriteLine("Bienvenido a nuestra empresa de catering");
        }

        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Opcion 0. Cerrar menu");
            Console.WriteLine("Opcion 1. Dar de alta un nuevo elemento");
            Console.WriteLine("Opcion 2. Modificar un elemento");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Por favor elija una opcion:");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;

        }
    }
}
