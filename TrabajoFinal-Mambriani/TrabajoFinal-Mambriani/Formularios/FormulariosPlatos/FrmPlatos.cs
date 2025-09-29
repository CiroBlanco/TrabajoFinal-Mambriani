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
    }
}
