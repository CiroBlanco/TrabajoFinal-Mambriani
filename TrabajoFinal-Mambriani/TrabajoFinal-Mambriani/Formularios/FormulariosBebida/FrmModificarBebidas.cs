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
    public partial class FrmModificarBebidas : Form
    {
        Bebida BebidaAModificar;
        private static FrmModificarBebidas _instancia;

        public static FrmModificarBebidas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmModificarBebidas();
                return _instancia;
            }
            private set { }
        }

        public FrmModificarBebidas()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtNombreBebida.Text = "";
            TxtDescripcionBebida.Text = "";
            ChkAlcoholica.Checked = false;
            TxtPrecioBebida.Text = "";
            BtnAgregarBebida.Enabled = true;
            BtnAgregarBebida.Visible = true;
            BtnEditarBebida.Enabled = false;
            BtnEditarBebida.Visible = false;
            this.Show();
        }
        public void MostrarEditar(Bebida BebidaModi)
        {
            BebidaAModificar = BebidaModi;
            TxtNombreBebida.Text = BebidaAModificar.nombre;
            TxtDescripcionBebida.Text = BebidaAModificar.descripcion;
            ChkAlcoholica.Checked = BebidaAModificar.alcoholica;
            TxtPrecioBebida.Text = BebidaAModificar.precio.ToString();
            BtnAgregarBebida.Enabled = false;
            BtnAgregarBebida.Visible = false;
            BtnEditarBebida.Enabled = true;
            BtnEditarBebida.Visible = true;
            this.Show();
        }
        private void BtnAgregarBebida_Click(object sender, EventArgs e)
        {
            Bebida nuevaBebida = new Bebida();

            nuevaBebida.nombre = TxtNombreBebida.Text;
            nuevaBebida.descripcion = TxtDescripcionBebida.Text;
            nuevaBebida.alcoholica = ChkAlcoholica.Checked;
            nuevaBebida.precio = float.Parse(TxtPrecioBebida.Text);


            nuevaBebida.Insertar();
            this.Hide();
            FrmBebidas.Instancia.Show();
            FrmBebidas.Instancia.ActualizarDatagrid();
        }
        private void BtnEditarBebida_Click(object sender, EventArgs e)
        {
            BebidaAModificar.nombre = TxtNombreBebida.Text;
            BebidaAModificar.descripcion = TxtDescripcionBebida.Text;
            BebidaAModificar.alcoholica = ChkAlcoholica.Checked;
            BebidaAModificar.precio = float.Parse(TxtPrecioBebida.Text);
            BebidaAModificar.Actualizar();
            this.Hide();
            FrmBebidas.Instancia.Show();
            FrmBebidas.Instancia.ActualizarDatagrid();
        }
        private void BtnCancelarBebida_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBebidas.Instancia.Show();
        }
    }
}
