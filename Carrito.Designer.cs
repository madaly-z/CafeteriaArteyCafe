namespace CafeteriaArteyCafe
{
    partial class Carrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFria = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnCaliente = new System.Windows.Forms.Button();
            this.btnPostres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.btnRegistro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnFria);
            this.panel2.Controls.Add(this.btnCarrito);
            this.panel2.Controls.Add(this.btnCaliente);
            this.panel2.Controls.Add(this.btnPostres);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 446);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arte y Cafe";
            // 
            // btnFria
            // 
            this.btnFria.BackColor = System.Drawing.Color.Linen;
            this.btnFria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFria.Image = ((System.Drawing.Image)(resources.GetObject("btnFria.Image")));
            this.btnFria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFria.Location = new System.Drawing.Point(3, 70);
            this.btnFria.Name = "btnFria";
            this.btnFria.Size = new System.Drawing.Size(190, 68);
            this.btnFria.TabIndex = 9;
            this.btnFria.Text = "Bebidas Frias";
            this.btnFria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFria.UseVisualStyleBackColor = false;
            this.btnFria.Click += new System.EventHandler(this.btnFria_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.Linen;
            this.btnCarrito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrito.Image")));
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(3, 297);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(190, 66);
            this.btnCarrito.TabIndex = 7;
            this.btnCarrito.Text = "Carrito";
            this.btnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnCaliente
            // 
            this.btnCaliente.BackColor = System.Drawing.Color.Linen;
            this.btnCaliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCaliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCaliente.Image")));
            this.btnCaliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaliente.Location = new System.Drawing.Point(3, 145);
            this.btnCaliente.Name = "btnCaliente";
            this.btnCaliente.Size = new System.Drawing.Size(190, 68);
            this.btnCaliente.TabIndex = 5;
            this.btnCaliente.Text = "Bebidas Calientes";
            this.btnCaliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaliente.UseVisualStyleBackColor = false;
            this.btnCaliente.Click += new System.EventHandler(this.btnCaliente_Click);
            // 
            // btnPostres
            // 
            this.btnPostres.BackColor = System.Drawing.Color.Linen;
            this.btnPostres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPostres.Image = ((System.Drawing.Image)(resources.GetObject("btnPostres.Image")));
            this.btnPostres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostres.Location = new System.Drawing.Point(3, 222);
            this.btnPostres.Name = "btnPostres";
            this.btnPostres.Size = new System.Drawing.Size(190, 69);
            this.btnPostres.TabIndex = 6;
            this.btnPostres.Text = "Postres";
            this.btnPostres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPostres.UseVisualStyleBackColor = false;
            this.btnPostres.Click += new System.EventHandler(this.btnPostres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Carrito";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Linen;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(3, 369);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(190, 66);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFria;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnCaliente;
        private System.Windows.Forms.Button btnPostres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistro;
    }
}