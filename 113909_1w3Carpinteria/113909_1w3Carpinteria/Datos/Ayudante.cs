using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _113909_1w3Carpinteria.Datos
{
    internal class Ayudante
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public Ayudante()
        {
            cnn = new SqlConnection();
            //cnn.ConnectionString = @"Data Source=sqlgabineteinformatico.frc.utn.edu.ar;User ID=alumnoprog22";
            //Proyecto>Propiedades>Recurso>creas cadena de conexion 
            //Guarda la cadena en los recursos del proyecto. C# nos otorga una lista de conexiones a bd. que no se copila todo el tiempo.
            cnn.ConnectionString = Properties.Resources.CadenaConeccion;
        }
        public DataTable EjecutarSPConsulta(string nombreSP)
        { 
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }
    }
}
