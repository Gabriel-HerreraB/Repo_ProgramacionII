using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113909_1w3Carpinteria.Dominio
{
    internal class DetallePresupuesto//es internal(todas las clases dentro de un namespace pueden verse c:
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public DetallePresupuesto(int cantidad, Producto p)
        {
            Cantidad = 0;
            Producto = p;
        }
        public float Subtotal()//delegacion de responsabilidad 
        {
            return Producto.Precio * Cantidad; 
        }
    }
}
