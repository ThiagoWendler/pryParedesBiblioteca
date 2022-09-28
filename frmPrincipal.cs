using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryParedesBiblioteca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca biblioteca = new frmBiblioteca();
            biblioteca.ShowDialog();
        }
    }
}
