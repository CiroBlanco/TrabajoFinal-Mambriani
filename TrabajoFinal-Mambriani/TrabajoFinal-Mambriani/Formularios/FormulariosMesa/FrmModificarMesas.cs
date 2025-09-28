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
    public partial class FrmModificarMesas : Form
    {
        Mesa MesaAModificar;
        private static FrmModificarMesas _instancia;

        public static FrmModificarMesas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmModificarMesas();
                return _instancia;
            }
            private set { }
        }
        public FrmModificarMesas()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtCantidadPersonas.Text = "";
            
            BtnAgregarMesa.Enabled = true;
            BtnAgregarMesa.Visible = true;
            BtnEditarMesa.Enabled = false;
            BtnEditarMesa.Visible = false;

            this.Show();
        }

        public void MostrarEditar(Mesa MesaModi)
        {
            MesaAModificar = MesaModi;

            TxtCantidadPersonas.Text = MesaAModificar.cantidad_personas.ToString();

            BtnAgregarMesa.Enabled = false;
            BtnAgregarMesa.Visible = false;
            BtnEditarMesa.Enabled = true;
            BtnEditarMesa.Visible = true;

            this.Show();
        }
        private void BtnAgregarMesa_Click(object sender, EventArgs e)
        {
            Mesa nuevaMesa = new Mesa();

            nuevaMesa.cantidad_personas = int.Parse(TxtCantidadPersonas.Text);
 

            nuevaMesa.Insertar();
            this.Hide();
            FrmMesas.Instancia.Show();
            FrmMesas.Instancia.ActualizarDatagrid();
        }
        private void BtnEditarMesa_Click(object sender, EventArgs e)
        {
            MesaAModificar.cantidad_personas = int.Parse(TxtCantidadPersonas.Text);

            MesaAModificar.Actualizar();
            this.Hide();
            FrmMesas.Instancia.Show();
            FrmMesas.Instancia.ActualizarDatagrid();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMesas.Instancia.Show();
        }
    }
}
