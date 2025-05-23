﻿using System;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form clasificacion = new ClasificacionPartidosForm();
            clasificacion.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPartidosForm Admin = new AdminPartidosForm();
            Admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdministradorForm Admin = new AdministradorForm();
            Admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClasificacionTablaForm clasificacion = new ClasificacionTablaForm();
            clasificacion.Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
