using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113909_1w3Carpinteria.Dominio
{
    internal class Producto
    {
        //propTabx2. propiedad (atributo y metodo 2x1ahre)
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }
        //ctor tabx2. Hay un constructor sin parametros por defecto siemmpre y cuando no haya otro 

        public Producto(int idProducto, string nombre, float precio, bool activo)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Activo = activo;;
        }
    }
}
