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
    public partial class FrmModificarMesero : Form
    {
            private static FrmModificarMesero _instancia;
            public static FrmModificarMesero Instancia
            {
                get
                {
                    if (_instancia == null)
                        _instancia = new FrmModificarMesero();
                    return _instancia;
                }
                private set { }
            }

            public FrmModificarMesero()
        {
            InitializeComponent();
        }
        public void MostrarAgregar()
        {
            TxtNombreMesero.Text = "";
            TxtDniMesero.Text = "";
            TxtTelefonoMesero.Text = "";
            DtpFechaNacimientoMesero.Value = DateTime.Now;
            DtpHorarioInicioMesero.Value = DateTime.Now;
            DtpHorarioFinMesero.Value = DateTime.Now;
            CmbSectorMesero.Text = "";
            BtnAgregarMesero.Enabled = true;
            BtnAgregarMesero.Visible = true;
            BtnEditarMesero.Enabled = false;
            BtnEditarMesero.Visible = false;
            this.Show();
        }
        public void MostrarEditar(Mesero MeseroModi)
        {
            TxtNombreMesero.Text = MeseroModi.nombre_completo;
            TxtDniMesero.Text = MeseroModi.dni.ToString();
            TxtTelefonoMesero.Text = MeseroModi.telefono.ToString();
            DtpFechaNacimientoMesero.Value = MeseroModi.fecha_nacimiento;
            DtpHorarioInicioMesero.Value = MeseroModi.horario_inicio;
            DtpHorarioFinMesero.Value = MeseroModi.horario_fin;
            CmbSectorMesero.Text = MeseroModi.id_sector.ToString();
            BtnAgregarMesero.Enabled = false;
            BtnAgregarMesero.Visible = false;
            BtnEditarMesero.Enabled = true;
            BtnEditarMesero.Visible = true;
            this.Show();
        }
        private void BtnAgregarMesero_Click(object sender, EventArgs e)
        {
            Mesero nuevoMesero = new Mesero();
            nuevoMesero.nombre_completo = TxtNombreMesero.Text;
            nuevoMesero.dni = int.Parse(TxtDniMesero.Text);
            nuevoMesero.telefono = int.Parse(TxtTelefonoMesero.Text);
            nuevoMesero.fecha_nacimiento = DtpFechaNacimientoMesero.Value;
            nuevoMesero.horario_inicio = DtpHorarioInicioMesero.Value;
            nuevoMesero.horario_fin = DtpHorarioFinMesero.Value;
            nuevoMesero.id_sector = int.Parse(CmbSectorMesero.Text);
            nuevoMesero.Insertar();
            this.Hide();
            FrmMesero.Instancia.ActualizarDatagrid();
            FrmMesero.Instancia.Show();
        }
        private void BtnEditarMesero_Click(object sender, EventArgs e)
        {
            Mesero MeseroModificado = new Mesero();
            MeseroModificado.nombre_completo = TxtNombreMesero.Text;
            MeseroModificado.dni = int.Parse(TxtDniMesero.Text);
            MeseroModificado.telefono = int.Parse(TxtTelefonoMesero.Text);
            MeseroModificado.fecha_nacimiento = DtpFechaNacimientoMesero.Value;
            MeseroModificado.horario_inicio = DtpHorarioInicioMesero.Value;
            MeseroModificado.horario_fin = DtpHorarioFinMesero.Value;
            MeseroModificado.id_sector = int.Parse(CmbSectorMesero.Text);
            MeseroModificado.Actualizar();
            this.Hide();
            FrmMesero.Instancia.ActualizarDatagrid();
            FrmMesero.Instancia.Show();
        }
        private void BtnCancelarMesero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMesero.Instancia.Show();
        }
    }
}
