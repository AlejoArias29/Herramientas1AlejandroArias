using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria.Transaccion
{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            if (string.IsNullOrWhiteSpace(titulo) && string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Por favor ingresa algun campo para hacer la busqueda");
                return;
            }
            var logica = new LibroLogica();
            var logicaTransaccion = new TransaccionLogica();
            var libro = logica.BuscarLibro(isbn, titulo);
            if (!string.IsNullOrEmpty(libro.ISBN))
            {
                txtISBN.Text = libro.ISBN;
                txtTitulo.Text = libro.Titulo;
                txtCompra.Text = libro.PrecioCompra.ToString();
                txtVenta.Text = libro.PrecioVenta.ToString();
                txtCantidad.Text = libro.CantidadActual.ToString();
                textCantidad.Text = logicaTransaccion.BuscarTransaccion(libro).ToString();

            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }
    }
}
