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
    public partial class ClasificacionTablaForm : Form
    {
        public ClasificacionTablaForm()
        {
            InitializeComponent();
        }

        private void ClasificacionTablaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new MenuForm();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new ClasificacionPartidosForm();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new AdminPartidosForm();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new AdministradorForm();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClasificacionTablaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'golesYSanciones.Sanciones' table. You can move, or remove it, as needed.
            this.sancionesTableAdapter.Fill(this.golesYSanciones.Sanciones);
            // TODO: This line of code loads data into the 'golesYSanciones.Goles' table. You can move, or remove it, as needed.
            this.golesTableAdapter.Fill(this.golesYSanciones.Goles);
            // TODO: This line of code loads data into the 'torneoMontesSanBartoloDataSet1.Clasificacion' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
