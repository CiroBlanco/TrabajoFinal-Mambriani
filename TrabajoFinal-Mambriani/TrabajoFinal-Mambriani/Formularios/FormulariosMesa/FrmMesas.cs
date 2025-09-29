namespace TrabajoFinal_Mambriani
{
    public partial class FrmMesas : Form
    {
        private List<Mesa> listaMesas;
        private static FrmMesas _instancia;

        public static FrmMesas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FrmMesas();
                return _instancia;
            }
            private set { }
        }
        public FrmMesas()
        {
            InitializeComponent();
        }
        public void MostrarMesas()
        {
            this.Show();
        }
        public void ActualizarDatagrid()
        {
            DgvMesas.Rows.Clear();
            listaMesas = Mesa.TraerTodos();

            if (listaMesas == null || listaMesas.Count <= 0)
                return;

            foreach (Mesa mesa in listaMesas)
                DgvMesas.Rows.Add(mesa.id_mesa, mesa.cantidad_personas, mesa.libre, mesa.id_sector);
        }

        private void BtnVolverMesas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Instancia.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModificarMesas.Instancia.MostrarAgregar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvMesas.SelectedRows.Count <= 0)
                return;

            int id;
            id = (int)DgvMesas.SelectedRows[0].Cells["Id_Mesa"].Value;

            FrmModificarMesas.Instancia.MostrarEditar(Mesa.TraerUno(id));
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvMesas.SelectedRows.Count <= 0)
                return;
            int idSeleccionado = (int)DgvMesas.SelectedRows[0].Cells["Id_Mesa"].Value;
            Mesa mesaAEliminar = Mesa.TraerUno(idSeleccionado);

            mesaAEliminar.Eliminar();
            ActualizarDatagrid();
        }
    }
}
