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
    public partial class FrmPlatos : Form
    {
        private List<Plato> listaPlatos;
        private static FrmPlatos _instancia;
        public static FrmPlatos Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmPlatos();
                return _instancia;
            }
            private set { }
        }
        public FrmPlatos()
        {
            InitializeComponent();
        }
        public void MostrarPlatos()
        {
            this.Show();

        }
        public void ActualizarDatagrid()
        {
            DgvPlatos.Rows.Clear();
            listaPlatos = Plato.TraerTodos();
            if (listaPlatos == null || listaPlatos.Count <= 0)
                return;
            foreach (Plato plato in listaPlatos)
                DgvPlatos.Rows.Add(plato.id_plato, plato.nombre, plato.descripcion, plato.precio);
        }

        private void BtnAgregarPlato_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModificarPlatos.Instancia.MostrarAgregar();
        }

        private void BtnVolverPlato_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }

        private void BtnEliminarPlato_Click(object sender, EventArgs e)
        {
            if (DgvPlatos.SelectedRows.Count <= 0)
                return;
            int idSeleccionado = (int)DgvPlatos.SelectedRows[0].Cells["Id_Plato"].Value;
            Plato PlatoAEliminar = Plato.TraerUno(idSeleccionado);

            PlatoAEliminar.Eliminar();
            ActualizarDatagrid();
        }

        private void BtnEditarPlato_Click(object sender, EventArgs e)
        {
            if (DgvPlatos.SelectedRows.Count <= 0)
                return;

            int id;
            id = (int)DgvPlatos.SelectedRows[0].Cells["Id_Plato"].Value;
            FrmModificarPlatos.Instancia.MostrarEditar(Plato.TraerUno(id));
            this.Hide();
        }
    }
}
