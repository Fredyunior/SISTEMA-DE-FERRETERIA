using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FERRETERIA.NEGOCIO
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "ferreteria";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";port=" + puerto + ";User Id=" + usuario
                + " ; " + "Password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("se conecto a la bse de datos");
            }
            catch(Exception ex)
            {

                MessageBox.Show("No se conecto a la base de datos, error:"+ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
            

    }
}