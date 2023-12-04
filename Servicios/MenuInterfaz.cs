using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_jpribui.Servicios
{
    /// <summary>
    /// Interfaz donde esta la cabecera de los metodos de interaccion con el usuario
    /// <author>jpr-04/12/23</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje al iniciar la aplicacion 
        /// <author>jpr-04/12/23</author>
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodod que muestra por pantalla el menu y le pide al usuario que de una opcion 
        /// <author>jpr-04/12/23</author>
        /// </summary>
        /// <returns>Devuelve la opcion que el usuario ha elegido</returns>
        public int mostrarMenu();
    }
}
