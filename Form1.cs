using PROYECTO_FERRETERIA.NEGOCIO;
using SISTEMA_DE_FERRETERIA.CConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_FERRETERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CPersona objetoPersona= new CPersona();
            objetoPersona.mostrarPersonas(dgvTotalPersonas);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           CConexion objetoConexion = new CConexion();
            objetoConexion.establecerConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
