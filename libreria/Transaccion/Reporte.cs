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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnMasCostoso_Click(object sender, EventArgs e)
        {
            var logicaTransaccion = new TransaccionLogica();
            string query = "SELECT TOP 1 * FROM Libros ORDER BY PrecioVenta DESC";
            var libro = logicaTransaccion.BuscarLibroMasMenosCostosoLogica(query);
            if (!string.IsNullOrEmpty(libro.ISBN))
            {
                txtISBN.Text = libro.ISBN;
                txtTitulo.Text = libro.Titulo;
                txtCompra.Text = libro.PrecioCompra.ToString();
                txtVenta.Text = libro.PrecioVenta.ToString();
                txtCantidad.Text = libro.CantidadActual.ToString();

            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }

        private void btnMenosCostoso_Click(object sender, EventArgs e)
        {
            var logicaTransaccion = new TransaccionLogica();
            string query = "SELECT TOP 1 * FROM Libros ORDER BY PrecioVenta ASC";
            var libro = logicaTransaccion.BuscarLibroMasMenosCostosoLogica(query);
            if (!string.IsNullOrEmpty(libro.ISBN))
            {
                txtISBN.Text = libro.ISBN;
                txtTitulo.Text = libro.Titulo;
                txtCompra.Text = libro.PrecioCompra.ToString();
                txtVenta.Text = libro.PrecioVenta.ToString();
                txtCantidad.Text = libro.CantidadActual.ToString();

            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }

        private void btnMasVendido_Click(object sender, EventArgs e)
        {
            var logicaTransaccion = new TransaccionLogica();
            string query = @"
                            SELECT TOP 1 L.ISBN, L.Titulo, SUM(T.Cantidad) AS TotalVendidos
                            FROM Transacciones T
                            INNER JOIN Libros L ON T.ISBN = L.ISBN
                            WHERE T.Tipo = 'Vender'
                            GROUP BY L.ISBN, L.Titulo
                            ORDER BY TotalVendidos DESC";
            var libro = logicaTransaccion.BuscarLibroMasMenosCostosoLogica(query);
            if (!string.IsNullOrEmpty(libro.ISBN))
            {
                txtISBN.Text = libro.ISBN;
                txtTitulo.Text = libro.Titulo;
                txtCompra.Text = libro.PrecioCompra.ToString();
                txtVenta.Text = libro.PrecioVenta.ToString();
                txtCantidad.Text = libro.CantidadActual.ToString();

            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }
    }
}
