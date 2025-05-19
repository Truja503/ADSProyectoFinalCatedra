using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrador.Modelo;
namespace Administrador
{
    public partial class AdministradorForm : Form
    {
        bddFutbol bd = new bddFutbol();
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ClasificacionTablaForm();
            form.Show();
            this.Hide();
        }

        private void AdministradorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Equipos team = new Equipos
                {
                    Nombre = txtEquipoName.Text,
                    FechaRegistro = DateTime.Now,
                };
                bd.Equipos.Add(team);
                bd.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Jugadore team = new Jugadore
                {
                    Nombre = textBox4.Text,
                    Numero = int.Parse(textBox5.Text),
                    EquipoID = Convert.ToInt32(comboBox1.SelectedValue),
                };
                bd.Jugadores.Add(team);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'torneoMontesSanBartoloDataSet3.Equipos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'torneoMontesSanBartoloDataSet2.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.torneoMontesSanBartoloDataSet2.Equipos);

        }
    }
}
