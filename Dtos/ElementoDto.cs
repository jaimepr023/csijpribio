using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_jpribui.Dtos
{
    /// <summary>
    /// Clase donde se encuentra todos los campos de los elementos(los atributos y caracteristicas)
    /// author>jpr-04/12/23</author>
    /// </summary>
    internal class ElementoDto
    {
        long idElemento =0;

        string codigoElemento = "aaaaa";

        string nombreElemento = "aaaaa";

       string descripcionElemento ="aaaaa";

        long cantidadElemento=0;

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public long CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        public ElementoDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, long cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public ElementoDto()
        {
        }

        override
            public string ToString()
        {
            string todo =
                "idElemento-->" + idElemento + "\n"+
                "nombreElemento--> " + nombreElemento + "\n"+
                "CodigoElemento--> " + codigoElemento + "\n"+
                "descripcionElemento--> " + descripcionElemento + "\n"+
                "cantidadElemento--> " + cantidadElemento + "\n";
                return todo;
        }
    }
}
