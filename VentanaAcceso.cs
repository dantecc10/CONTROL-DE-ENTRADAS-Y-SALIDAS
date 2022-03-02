using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_DE_ENTRADAS_Y_SALIDAS
{
    public partial class VentanaAcceso : Form
    {
        public VentanaAcceso()
        {
            InitializeComponent();
        }

        private void VentanaAcceso_Load(object sender, EventArgs e)
        {
            bool FinDelMundo = false;
            Cambio_de_hora:
            while (FinDelMundo==false)
            {
                string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                RelojEtiquetado.Text = datetime;
                /*
                 string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        label1.Text = datetime;
                 */
                goto Cambio_de_hora;
            }
        }
    }
}
