using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class AdminPartidosForm : Form
    {
        public AdminPartidosForm()
        {
            InitializeComponent();
        }

        private void AdminPartidosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminPartidosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDeDatos.Jugadores' table. You can move, or remove it, as needed.
            this.jugadoresTableAdapter.Fill(this.baseDeDatos.Jugadores);
            // TODO: This line of code loads data into the 'baseDeDatos.Partidos' table. You can move, or remove it, as needed.
            this.partidosTableAdapter.Fill(this.baseDeDatos.Partidos);
            // TODO: This line of code loads data into the 'baseDeDatos.Jornadas' table. You can move, or remove it, as needed.
            this.jornadasTableAdapter.Fill(this.baseDeDatos.Jornadas);
            // TODO: This line of code loads data into the 'baseDeDatos.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter1.Fill(this.baseDeDatos.Equipos);
            // TODO: This line of code loads data into the 'torneoMontesSanBartoloDataSet.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.torneoMontesSanBartoloDataSet.Equipos);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm home = new MenuForm();
            home.Show();
            this.Hide();
        }
    }
}
