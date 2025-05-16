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
    }
}
