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
    public partial class Registro_de_Producto : Form
    {
        public Registro_de_Producto()
        {
            InitializeComponent();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarDatosProducto()
        {
            throw new NotImplementedException();
        }

        private void Registro_de_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito a = new Carrito();
            a.Show();
            this.Hide();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            Postres a = new Postres();
            a.Show();
            this.Hide();
        }

        private void btnCaliente_Click(object sender, EventArgs e)
        {
            BebidasCalientes a = new BebidasCalientes();
            a.Show();
            this.Hide();
        }

        private void btnFria_Click(object sender, EventArgs e)
        {
            baseform a = new baseform();
            a.Show();
            this.Hide();
        }
    }
}
