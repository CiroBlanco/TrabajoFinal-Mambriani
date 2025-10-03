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
    public partial class FrmMesero : Form
    {
        private List<Mesero> listaMeseros;
        private static FrmMesero _instancia;
        public static FrmMesero Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmMesero();
                return _instancia;
            }
            private set { }
        }
        public FrmMesero()
        {
            InitializeComponent();
        }
        public void MostrarMeseros()
        {
            this.Show();
        }
        public void ActualizarDatagrid()
        {
            DgvMeseros.Rows.Clear();
            listaMeseros = Mesero.TraerTodos();
            if (listaMeseros == null || listaMeseros.Count <= 0)
                return;
            foreach (Mesero mesero in listaMeseros)
                DgvMeseros.Rows.Add(mesero.id_mesero, mesero.nombre_completo, mesero.dni, mesero.telefono, mesero.fecha_nacimiento.ToShortDateString(), mesero.horario_inicio, mesero.horario_fin, mesero.id_sector);
        }
        private void BtnVolverMeseros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }

    }
}
