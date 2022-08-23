using _113909_1w3Carpinteria.Datos;
using _113909_1w3Carpinteria.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _113909_1w3Carpinteria.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        Presupuesto oPresupuesto;
        Ayudante oDatos;
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            oPresupuesto = new Presupuesto();
            oDatos = new Ayudante();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
            CargarProductos();
            lblNroPresupuesto.Text += ProximoPresupuesto();
        }

        private void CargarProductos()
        {
            DataTable Tabla = new DataTable();
            Tabla=oDatos.EjecutarSPConsulta("SP_CONSULTAR_PRODUCTOS");
            cboProductos.DataSource = Tabla;
            cboProductos.ValueMember = Tabla.Columns[0].ColumnName;
            cboProductos.DisplayMember = Tabla.Columns[1].ColumnName;
        }
    }
}
