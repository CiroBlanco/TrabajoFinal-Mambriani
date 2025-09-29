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
    public partial class FrmModificarSectores : Form
    {
        Sector SectorAModificar;
        private static FrmModificarSectores _instancia;

        public static FrmModificarSectores Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmModificarSectores();
                return _instancia;
            }
            private set { }
        }

        public FrmModificarSectores()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtNombreSector.Text = "";
            BtnAgregarSector.Enabled = true;
            BtnAgregarSector.Visible = true;
            BtnEditarSector.Enabled = false;
            BtnEditarSector.Visible = false;
            this.Show();
        }
        public void MostrarEditar(Sector SectorModi)
        {
            SectorAModificar = SectorModi;
            TxtNombreSector.Text = SectorAModificar.nombre;
            BtnAgregarSector.Enabled = false;
            BtnAgregarSector.Visible = false;
            BtnEditarSector.Enabled = true;
            BtnEditarSector.Visible = true;
            this.Show();
        }
        private void BtnAgregarSector_Click(object sender, EventArgs e)
        {
            Sector nuevoSector = new Sector();

            nuevoSector.nombre = TxtNombreSector.Text;

            nuevoSector.Insertar();
            this.Hide();
            FrmSectores.Instancia.Show();
            FrmSectores.Instancia.ActualizarDatagrid();
        }
        private void BtnEditarSector_Click(object sender, EventArgs e)
        {
            SectorAModificar.nombre = TxtNombreSector.Text;
           SectorAModificar.Actualizar();
            this.Hide();
            FrmSectores.Instancia.Show();
            FrmSectores.Instancia.ActualizarDatagrid();
        }
        private void BtnCancelarSector_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSectores.Instancia.Show();
        }
    }
}
