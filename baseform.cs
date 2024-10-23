using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaArteyCafe
{
    public partial class baseform : Form
    {
        private object panelContenedor;

        public baseform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBebidasFrias_Click(object sender, EventArgs e)
        {
            BebidasCalientes cali = new BebidasCalientes();
            cali.Show();
            this.Hide();
        }

        private void btnBebidasCaliente_Click(object sender, EventArgs e)
        {


        }
       
        private void btnFria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCaliente_Click(object sender, EventArgs e)
        {
            BebidasCalientes cali = new BebidasCalientes();
            cali.Show();
            this.Hide();
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
