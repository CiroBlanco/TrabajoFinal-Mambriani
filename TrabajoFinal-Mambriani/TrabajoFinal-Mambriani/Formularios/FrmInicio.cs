using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_Mambriani
{
    public partial class FrmInicio : Form
    {
        private static FrmInicio _instancia;

        public static FrmInicio Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmInicio();
                return _instancia;
            }
            private set { }
        }
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnMesas_Click(object sender, EventArgs e)
        {
            FrmMesas.Instancia.MostrarMesas();
            this.Hide();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            FrmBebidas.Instancia.MostrarBebidas();
            this.Hide();
        }

        private void BtnSectores_Click(object sender, EventArgs e)
        {
            FrmSectores.Instancia.MostrarSectores();
            this.Hide();
        }

        private void BtnPlatos_Click(object sender, EventArgs e)
        {
            FrmPlatos.Instancia.MostrarPlatos();
            this.Hide();
        }

        private void BtnChefs_Click(object sender, EventArgs e)
        {
            FrmChefs.Instancia.MostrarChefs();
            this.Hide();
        }
    }
}
