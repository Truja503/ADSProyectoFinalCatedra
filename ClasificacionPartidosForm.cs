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
    public partial class ClasificacionPartidosForm : Form
    {
        public ClasificacionPartidosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new MenuForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new AdminPartidosForm();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ClasificacionTablaForm();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new AdministradorForm();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClasificacionPartidosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClasificacionPartidosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db2025.Vista_Puntos_Equipos' table. You can move, or remove it, as needed.
            this.vista_Puntos_EquiposTableAdapter.Fill(this.db2025.Vista_Puntos_Equipos);
            // TODO: This line of code loads data into the 'baseDeDatosNueva.Jornadas' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'baseDeDatosNueva.Partidos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'torneoMontesSanBartoloDataSet4.Clasificacion' table. You can move, or remove it, as needed.

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Close();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {

            AdministradorForm cl = new AdministradorForm();
            cl.Show();
            this.Hide();
        }

        private void btnGolesySanciones_Click(object sender, EventArgs e)
        {
            ClasificacionTablaForm cl = new ClasificacionTablaForm();
            cl.Show();
            this.Hide();
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vista_Puntos_EquiposTableAdapter.FillBy(this.db2025.Vista_Puntos_Equipos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
