using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaArteyCafe
{
    public partial class BebidasCalientes : Form
    {
        public BebidasCalientes()
        {
            InitializeComponent();
        }

        private void btnFria_Click(object sender, EventArgs e)
        {
            baseform y = new baseform();
            y.Show();
            this.Hide();
        }

        private void btnCaliente_Click(object sender, EventArgs e)
        {

        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            Postres postres = new Postres();
            postres.Show();
            this.Hide();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito ca = new Carrito();
            ca.Show();
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro_de_Producto a = new Registro_de_Producto();
            a.Show();
            this.Hide();
        }
    }
}
