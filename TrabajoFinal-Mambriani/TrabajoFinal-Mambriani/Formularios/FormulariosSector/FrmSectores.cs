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
    public partial class FrmSectores : Form
    {
        private List<Sector> listaSectores;
        private static FrmSectores _instancia;

        public static FrmSectores Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmSectores();
                return _instancia;
            }
            private set { }
        }
        public FrmSectores()
        {
            InitializeComponent();
        }
        public void MostrarSectores()
        {
            this.Show();
        }
        public void ActualizarDatagrid()
        {
            DgvSectores.Rows.Clear();
            listaSectores = Sector.TraerTodos();
            if (listaSectores == null || listaSectores.Count <= 0)
                return;
            foreach (Sector sector in listaSectores)
                DgvSectores.Rows.Add(sector.id_sector, sector.nombre);
        }

        private void BtnAgregarSector_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnVolverSector_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }
    }
}
