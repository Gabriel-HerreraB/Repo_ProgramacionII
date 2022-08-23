using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113909_1w3Carpinteria.Dominio
{
    internal class Presupuesto
    {
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Cliente { get; set; }
        public float Descuento { get; set; }
        public int NroPresupuesto { get; set; }
        public float Total { get; set; }//lo calculado no se almacena pero lo ponemos SOLO pq esta en la BD. Sino seria un comportamiento(estado)
        public List<DetallePresupuesto> Detalles{ get; }//la list va a almacenar datos del tipo DP o aquellos que hereden de el. Le sacamos el set pq modificiarlo deberia ser cosa de la propia clase

        public Presupuesto(string cliente, float descuento, int nro)
        {
            NroPresupuesto = nro;
            FechaAlta = DateTime.Now;
            Cliente = cliente;
            Descuento = descuento;
            Total = 0;
            Detalles = new List<DetallePresupuesto>();//crea un objeto list que almacena dp
        }

        public Presupuesto()
        {
        }

        public void AgregarDetalle(DetallePresupuesto detalle)
        {
            if(detalle != null)
                Detalles.Add(detalle);//guardamos en la list un nuevo detalle. La coleccion si puede almacenar null(en este caso no xd)
        }
        public void BorrarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Remove(detalle);//borra por referencia. Recorre toda la lista y elimina aquel que tenga esa referencia. para borrar por numero tenes que hacer una busqueda(foreach)
        }
    }
}
