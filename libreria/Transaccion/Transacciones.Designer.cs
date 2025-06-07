namespace libreria.Transaccion
{
    partial class Transacciones
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
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(570, 220);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.ReadOnly = true;
            this.textCantidad.Size = new System.Drawing.Size(146, 20);
            this.textCantidad.TabIndex = 53;
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.AutoSize = true;
            this.lblTransaccion.Location = new System.Drawing.Point(396, 223);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(168, 13);
            this.lblTransaccion.TabIndex = 52;
            this.lblTransaccion.Text = "transacciones de abastecimiento: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(44, 216);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 13);
            this.lblCantidad.TabIndex = 51;
            this.lblCantidad.Text = "Cantidad Inicial:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(164, 216);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 50;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(516, 170);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.ReadOnly = true;
            this.txtVenta.Size = new System.Drawing.Size(200, 20);
            this.txtVenta.TabIndex = 49;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(396, 170);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(71, 13);
            this.lblPrecioVenta.TabIndex = 48;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(44, 170);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioCompra.TabIndex = 47;
            this.lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(164, 170);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.ReadOnly = true;
            this.txtCompra.Size = new System.Drawing.Size(200, 20);
            this.txtCompra.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Título:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "ISBN:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(447, 50);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 20);
            this.txtTitulo.TabIndex = 40;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(365, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Título:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(107, 50);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 38;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(37, 50);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 37;
            this.lblISBN.Text = "ISBN:";
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.lblTransaccion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label lblTransaccion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
    }
}