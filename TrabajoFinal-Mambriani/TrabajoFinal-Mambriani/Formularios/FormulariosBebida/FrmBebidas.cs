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
    public partial class FrmBebidas : Form
    {
        private List<Bebida> listaBebidas;
        private static FrmBebidas _instancia;

        public static FrmBebidas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmBebidas();
                return _instancia;
            }
            private set { }
        }
        public FrmBebidas()
        {
            InitializeComponent();
        }
        public void MostrarBebidas()
        {
            this.Show();
        }
        public void ActualizarDatagrid()
        {
            DgvBebidas.Rows.Clear();
            listaBebidas = Bebida.TraerTodos();

            if (listaBebidas == null || listaBebidas.Count <= 0)
                return;

            foreach (Bebida bebida in listaBebidas)
                DgvBebidas.Rows.Add(bebida.id_bebida, bebida.nombre, bebida.descripcion, bebida.alcoholica, bebida.precio);
        }

        private void BtnAgregarBebida_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModificarBebidas.Instancia.MostrarAgregar();
        }

        private void BtnEditarBebida_Click(object sender, EventArgs e)
        {

            if (DgvBebidas.SelectedRows.Count <= 0)
                return;

            int id;
            id = (int)DgvBebidas.SelectedRows[0].Cells["Id_Bebida"].Value;
            FrmModificarBebidas.Instancia.MostrarEditar(Bebida.TraerUno(id));
            this.Hide();
        }

        private void BtnEliminarBebida_Click(object sender, EventArgs e)
        {
            if (DgvBebidas.SelectedRows.Count <= 0)
                return;
            int idSeleccionado = (int)DgvBebidas.SelectedRows[0].Cells["Id_Bebida"].Value;
            Bebida bebidaAEliminar = Bebida.TraerUno(idSeleccionado);

            bebidaAEliminar.Eliminar();
            ActualizarDatagrid();
        }

        private void BtnVolverBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }
    }
}
