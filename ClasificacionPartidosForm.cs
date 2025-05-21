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
    }
}
