using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaNotas ListadoNotas = new ListaNotas();
        ListaNotas ListadoNotasOriginal = new ListaNotas();
        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAlumno.Text == "" || txtMateria.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos porfavor");
                
            }
            
            else
            {
                lblSalida.Text = ListadoNotas.CargarDatos(txtAlumno.Text, txtMateria.Text, txtNota.Text);
                ListadoNotasOriginal.CargarDatos(txtAlumno.Text, txtMateria.Text, txtNota.Text);
            }

           
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            ListadoNotas.OrdenarLista();
            lblSalida.Text = ListadoNotas.RegistroDeNotas();
        }

        private void BtnOriginal_Click(object sender, EventArgs e)
        {
            lblSalida.Text = ListadoNotasOriginal.RegistroDeNotas();
        }
    }
}
