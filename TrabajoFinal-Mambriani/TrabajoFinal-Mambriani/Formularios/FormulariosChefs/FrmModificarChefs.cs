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
    public partial class FrmModificarChefs : Form
    {
        private static FrmModificarChefs _instancia;
        public static FrmModificarChefs Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmModificarChefs();
                return _instancia;
            }
            private set { }
        }

        public FrmModificarChefs()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtNombreChef.Text = "";
            TxtDniChef.Text = "";
            TxtTelefonoChef.Text = "";
            DtpFechaNacimientoChef.Value = DateTime.Now;
            DtpHorarioInicioChef.Value = DateTime.Now;
            DtpHorarioFinChef.Value = DateTime.Now;
            CmbSectorChef.Text = "";
            BtnAgregarChef.Enabled = true;
            BtnAgregarChef.Visible = true;
            BtnEditarChef.Enabled = false;
            BtnEditarChef.Visible = false;
            this.Show();
        }
        public void MostrarEditar(Chef ChefModi)
        {   
            TxtNombreChef.Text = ChefModi.nombre_completo;
            TxtDniChef.Text = ChefModi.dni.ToString();
            TxtTelefonoChef.Text = ChefModi.telefono.ToString();
            DtpFechaNacimientoChef.Value = ChefModi.fecha_nacimiento;
            DtpHorarioInicioChef.Value = ChefModi.horario_inicio;
            DtpHorarioFinChef.Value = ChefModi.horario_fin;
            CmbSectorChef.Text = ChefModi.id_sector.ToString();
            BtnAgregarChef.Enabled = false;
            BtnAgregarChef.Visible = false;
            BtnEditarChef.Enabled = true;
            BtnEditarChef.Visible = true;
            this.Show();
        }
        private void BtnAgregarChef_Click(object sender, EventArgs e)
        {
            Chef nuevoChef = new Chef();
            nuevoChef.nombre_completo = TxtNombreChef.Text;
            nuevoChef.dni = int.Parse(TxtDniChef.Text);
            nuevoChef.telefono = int.Parse(TxtTelefonoChef.Text);
            nuevoChef.fecha_nacimiento = DtpFechaNacimientoChef.Value;
            nuevoChef.horario_inicio = DtpHorarioInicioChef.Value;
            nuevoChef.horario_fin = DtpHorarioFinChef.Value;
            nuevoChef.id_sector = int.Parse(CmbSectorChef.Text);
            nuevoChef.Insertar();
            this.Hide();
            FrmChefs.Instancia.ActualizarDatagrid();
            FrmChefs.Instancia.Show();
        }
        private void BtnEditarChef_Click(object sender, EventArgs e)
        {
            Chef chefModificado = new Chef();
            chefModificado.nombre_completo = TxtNombreChef.Text;
            chefModificado.dni = int.Parse(TxtDniChef.Text);
            chefModificado.telefono = int.Parse(TxtTelefonoChef.Text);
            chefModificado.fecha_nacimiento = DtpFechaNacimientoChef.Value;
            chefModificado.horario_inicio = DtpHorarioInicioChef.Value;
            chefModificado.horario_fin = DtpHorarioFinChef.Value;
            chefModificado.id_sector = int.Parse(CmbSectorChef.Text);
            chefModificado.Actualizar();
            this.Hide();
            FrmChefs.Instancia.ActualizarDatagrid();
            FrmChefs.Instancia.Show();
        }
        private void BtnCancelarChef_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChefs.Instancia.Show();
        }
    }
}
