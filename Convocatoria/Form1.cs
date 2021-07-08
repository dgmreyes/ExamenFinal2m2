using Convocatoria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convocatoria
{
    public partial class Form1 : Form
    {
        public PlazosModel plazosModel { get; set; }
        public Form1()
        {
            InitializeComponent();
            plazosModel = new PlazosModel();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plazos Plazo = new Plazos();
            Plazo.plazosModel = plazosModel;
            Plazo.MdiParent = this;
            Plazo.Show();
        }
    }
}
