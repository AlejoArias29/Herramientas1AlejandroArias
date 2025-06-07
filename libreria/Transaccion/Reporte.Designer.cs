namespace libreria.Transaccion
{
    partial class Reporte
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMasCostoso = new System.Windows.Forms.Button();
            this.btnMenosCostoso = new System.Windows.Forms.Button();
            this.btnMasVendido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(37, 199);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 13);
            this.lblCantidad.TabIndex = 44;
            this.lblCantidad.Text = "Cantidad Inicial:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(157, 199);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 43;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(509, 153);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.ReadOnly = true;
            this.txtVenta.Size = new System.Drawing.Size(200, 20);
            this.txtVenta.TabIndex = 42;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(389, 153);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(71, 13);
            this.lblPrecioVenta.TabIndex = 41;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(37, 153);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioCompra.TabIndex = 40;
            this.lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(157, 153);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.ReadOnly = true;
            this.txtCompra.Size = new System.Drawing.Size(200, 20);
            this.txtCompra.TabIndex = 39;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(509, 109);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(200, 20);
            this.txtTitulo.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Título:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(157, 109);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "ISBN:";
            // 
            // btnMasCostoso
            // 
            this.btnMasCostoso.Location = new System.Drawing.Point(44, 38);
            this.btnMasCostoso.Name = "btnMasCostoso";
            this.btnMasCostoso.Size = new System.Drawing.Size(144, 23);
            this.btnMasCostoso.TabIndex = 45;
            this.btnMasCostoso.Text = "Libro Mas Costoso";
            this.btnMasCostoso.UseVisualStyleBackColor = true;
            this.btnMasCostoso.Click += new System.EventHandler(this.btnMasCostoso_Click);
            // 
            // btnMenosCostoso
            // 
            this.btnMenosCostoso.Location = new System.Drawing.Point(302, 38);
            this.btnMenosCostoso.Name = "btnMenosCostoso";
            this.btnMenosCostoso.Size = new System.Drawing.Size(125, 23);
            this.btnMenosCostoso.TabIndex = 46;
            this.btnMenosCostoso.Text = "Libro Menos Costoso";
            this.btnMenosCostoso.UseVisualStyleBackColor = true;
            this.btnMenosCostoso.Click += new System.EventHandler(this.btnMenosCostoso_Click);
            // 
            // btnMasVendido
            // 
            this.btnMasVendido.Location = new System.Drawing.Point(509, 38);
            this.btnMasVendido.Name = "btnMasVendido";
            this.btnMasVendido.Size = new System.Drawing.Size(151, 23);
            this.btnMasVendido.TabIndex = 47;
            this.btnMasVendido.Text = "Libro Mas Vendido";
            this.btnMasVendido.UseVisualStyleBackColor = true;
            this.btnMasVendido.Click += new System.EventHandler(this.btnMasVendido_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMasVendido);
            this.Controls.Add(this.btnMenosCostoso);
            this.Controls.Add(this.btnMasCostoso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasCostoso;
        private System.Windows.Forms.Button btnMenosCostoso;
        private System.Windows.Forms.Button btnMasVendido;
    }
}