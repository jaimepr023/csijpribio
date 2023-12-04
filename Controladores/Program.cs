using csi_jpribui.Dtos;
using csi_jpribui.Servicios;

namespace csijprirub
{
    /// <summary>
    /// Clase donde contiene nuestro metodo main
    /// <author>jpr-04/12/23</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main donde se encuentra nuesto procedimiento de la aplicacion
        /// <author>jpr-04/12/23</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            List<ElementoDto> elementoDtos = new List<ElementoDto>();

            ElementoInterfaz ei = new ElementoImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            mi.mensajeBienvenida();

            int opcion;
            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenu();

                switch(opcion)
                {
                    case 0:
                        Console.WriteLine("[INFOS]- Se va a cerrar el menu y la aplicacion. Que tenga un buen dia.");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("[INFOS]-Aqui podras dar de alta un elemento");
                        ei.darAltaElemento(elementoDtos);
                        foreach(ElementoDto elementos in elementoDtos)
                        {
                            Console.WriteLine(elementos.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("[INFOS]-Ahora podras modificar la cantidad que tiene.");
                            ei.eliminarCantidad(elementoDtos);
                        foreach (ElementoDto elementos in elementoDtos)
                        {
                            Console.WriteLine(elementos.ToString());
                        }
                        break;
                }
            }

        }

    }
}