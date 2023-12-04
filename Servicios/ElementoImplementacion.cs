using csi_jpribui.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_jpribui.Servicios
{
    /// <summary>
    /// Implementacion donde esta la logica de nuestros metodos e implementa la interfaz de elementos.
    /// <author>jpr-04/12/23</author>
    /// </summary>
    internal class ElementoImplementacion : ElementoInterfaz
    {
        /// <summary>
        /// Metodo privado donde esta la funcionalidad de crear un elemento nuevo 
        /// <author>jpr-04/12/23</author>
        /// </summary>
        /// <returns>Este metodod devuelve el elemento que el usuario le da.</returns>
        private ElementoDto crearElemento()
        {
            ElementoDto elemento = new ElementoDto();
            Console.WriteLine("Dame el identificador del elemento:");
            elemento.IdElemento= Int64.Parse(Console.ReadLine());

            Console.WriteLine("Dame el nombre del objeto:");
            elemento.NombreElemento = Console.ReadLine();

            Console.WriteLine("Dame la descripcion del objeto:");
            elemento.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Dame la cantidad que usted tiene:");
            elemento.CantidadElemento=Int64.Parse(Console.ReadLine());

            elemento.CodigoElemento=elemento.IdElemento + elemento.NombreElemento;

            return elemento;
        }

        public void darAltaElemento(List<ElementoDto> ListaAlta)
        {
            ElementoDto nuevoElemento= crearElemento();
            ListaAlta.Add(nuevoElemento);
        }

        public void eliminarCantidad(List<ElementoDto> ListaModificada)
        {
            Console.WriteLine("Dime el codigo de elemento con el cual editaras la cantidad del elemento que tienes:");
            string verificar = Console.ReadLine();

         foreach(ElementoDto elemento in ListaModificada)
            {
                if (elemento.CodigoElemento.Equals(verificar))
                {
                    Console.WriteLine("Dime la cantidad exacta que quieres eliminar:");
                    long quitar = Int64.Parse(Console.ReadLine());
                    elemento.CantidadElemento = elemento.CantidadElemento-quitar;

                }
            }
              
        }
    }
}
