using MySql.Data.MySqlClient;
using PROYECTO_FERRETERIA.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_FERRETERIA.CConexion
{
    internal class CPersona
    {
        public void mostrarPersonas(DataGridView TablaPersona)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "select * from persona";
                TablaPersona.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaPersona.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
             catch(Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la base de datos,error:"+ ex.ToString());
            }
        }
    }
}
