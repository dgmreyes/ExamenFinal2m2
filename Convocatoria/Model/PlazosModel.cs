using Convocatoria.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convocatoria.Model
{
    public class PlazosModel
    {
        private Prestamos[] prestamos;
        public PlazosModel()
        {

        }
        public void AgregarTabla(Prestamos prm)
        {
            if(prestamos == null)
            {
                prestamos = new Prestamos[1];
                prestamos[0] = prm;
                return;
            }
            Prestamos[] tmp = new Prestamos[prestamos.Length + 1];
            Array.Copy(prestamos, tmp, prestamos.Length);
            tmp[tmp.Length - 1] = prm;
            prestamos = tmp;
            
        }
        public Prestamos [] getAll()
        {
            return prestamos;
        }
    }
}
