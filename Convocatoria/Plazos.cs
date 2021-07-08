using Convocatoria.Model;
using Convocatoria.Poco;
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
    public partial class Plazos : Form
    {
        
        public Plazos()
        {
            InitializeComponent();
        }
        public PlazosModel plazosModel;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Visualizacion visualizacion = new Visualizacion();
            visualizacion.plazosModel = plazosModel;
            visualizacion.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Monto";
            dataGridView1.Columns[1].Name = "Plazo";
            dataGridView1.Columns[2].Name = "Tasa";
            dataGridView1.Columns[3].Name = "Periodo";
            if (plazosModel.getAll() != null)
            {
                foreach(Prestamos prestamos in plazosModel.getAll())
                {
                    dataGridView1.Rows.Add(prestamos.toArray() );
                }

            }
        }
    }
}
