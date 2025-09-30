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
    public partial class FrmChefs : Form
    {
        private List<Chef> listaChefs;
        private static FrmChefs _instancia;
        public static FrmChefs Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmChefs();
                return _instancia;
            }
            private set { }
        }
        public FrmChefs()
        {
            InitializeComponent();
        }
        public void MostrarChefs()
        {
            this.Show();
        }
        public void ActualizarDatagrid()
        {
            DgvChefs.Rows.Clear();
            listaChefs = Chef.TraerTodos();
            if (listaChefs == null || listaChefs.Count <= 0)
                return;
            foreach (Chef chef in listaChefs)
                DgvChefs.Rows.Add(chef.id_chef, chef.nombre_completo, chef.dni, chef.telefono, chef.fecha_nacimiento.ToShortDateString(), chef.horario_inicio, chef.horario_fin, chef.id_sector);
        }
        private void BtnVolverChefs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }
        private void BtnAgregarChefs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModificarChefs.Instancia.MostrarAgregar();
        }
    }
}
