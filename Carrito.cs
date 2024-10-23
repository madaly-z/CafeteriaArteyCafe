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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            Postres postres = new Postres();
            postres.Show();
            this.Hide();
        }

        private void btnCaliente_Click(object sender, EventArgs e)
        {
            BebidasCalientes postres = new BebidasCalientes();
            postres.Show();
            this.Hide();
        }

        private void btnFria_Click(object sender, EventArgs e)
        {
            baseform postres = new baseform();
            postres.Show();
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