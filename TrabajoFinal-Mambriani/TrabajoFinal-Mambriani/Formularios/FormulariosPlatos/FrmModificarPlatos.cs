using SQLitePCL;
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
    public partial class FrmModificarPlatos : Form
    {
        Plato PlatoAModificar;
        private static FrmModificarPlatos _instancia;

        public static FrmModificarPlatos Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmModificarPlatos();
                return _instancia;
            }
            private set { }
        }
        public FrmModificarPlatos()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtNombrePlato.Text = "";
            TxtDescripcionPlato.Text = "";
            TxtPrecioPlato.Text = "";
            BtnAgregarPlato.Enabled = true;
            BtnAgregarPlato.Visible = true;
            BtnEditarPlato.Enabled = false;
            BtnEditarPlato.Visible = false;
            this.Show();
        }
        public void MostrarEditar(Plato PlatoModi)
        {
            PlatoAModificar = PlatoModi;
            TxtNombrePlato.Text = PlatoAModificar.nombre;
            TxtDescripcionPlato.Text = PlatoAModificar.descripcion;
            TxtPrecioPlato.Text = PlatoAModificar.precio.ToString();
          
            BtnAgregarPlato.Enabled = false;
            BtnAgregarPlato.Visible = false;
            BtnEditarPlato.Enabled = true;
            BtnEditarPlato.Visible = true;
            this.Show();
        }
        private void BtnAgregarPlato_Click(object sender, EventArgs e)
        {
            Plato nuevoPlato = new Plato();

            nuevoPlato.nombre = TxtNombrePlato.Text;
            nuevoPlato.descripcion = TxtDescripcionPlato.Text;
            nuevoPlato.precio = float.Parse(TxtPrecioPlato.Text);

            nuevoPlato.Insertar();
            this.Hide();
            FrmPlatos.Instancia.Show();
            FrmPlatos.Instancia.ActualizarDatagrid();
        }
        private void BtnEditarPlato_Click(object sender, EventArgs e)
        {
            PlatoAModificar.nombre = TxtNombrePlato.Text;
            PlatoAModificar.descripcion = TxtDescripcionPlato.Text;
            PlatoAModificar.precio = float.Parse(TxtPrecioPlato.Text);
            PlatoAModificar.Actualizar();
            this.Hide();
            FrmPlatos.Instancia.Show();
            FrmPlatos.Instancia.ActualizarDatagrid();
        }
        private void BtnCancelarPlato_Click(object sender, EventArgs e)
        {
            FrmPlatos.Instancia.Show();
            this.Hide();
        }
    }
}
