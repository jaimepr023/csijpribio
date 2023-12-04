using csi_jpribui.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_jpribui.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra la cabecera de los metodos en relacion con la operativa de los elementos 
    /// <author>jpr-04/12/23</author>
    /// </summary>
    internal interface ElementoInterfaz
    {
        /// <summary>
        /// Metodod que da de alta un nuevo elemento con todas sus caracteristicas 
        /// <author>jpr-04/12/23</author>
        /// </summary>
        /// <param name="ListaAlta">Le damos el parametro de nuestra lista</param>
        public void darAltaElemento(List<ElementoDto> ListaAlta);

        /// <summary>
        /// Metodo que pide al usuario la cantidad del elemento que desea eliminar y lo realiza 
        /// <author>jpr-04/12/23</author>
        /// </summary>
        /// <param name="ListaModificada">Le damos el parametro de nuestra lista</param>
        public void eliminarCantidad(List<ElementoDto> ListaModificada);

    }
}
