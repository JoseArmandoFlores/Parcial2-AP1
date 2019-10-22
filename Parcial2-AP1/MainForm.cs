using Parcial2_AP1.UI.Consultas;
using Parcial2_AP1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes x = new rEstudiantes();
            x.MdiParent = this;
            x.Show();
        }

        private void XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiantes x = new cEstudiantes();
            x.MdiParent = this;
            x.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategorias categorias = new rCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }
    }
}
