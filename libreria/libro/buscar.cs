using logica;
using modelo;
using System;
using System.Windows.Forms;

namespace libreria.libro
{
    public partial class buscar : Form
    {
        public buscar()
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
            var libro = logica.BuscarLibro(isbn, titulo);
            if (!string.IsNullOrEmpty(libro.ISBN))
            {
                txtISBN.Text = libro.ISBN;
                txtTitulo.Text = libro.Titulo;
                txtCompra.Text = libro.PrecioCompra.ToString();
                txtVenta.Text = libro.PrecioVenta.ToString();
                txtCantidad.Text = libro.CantidadActual.ToString();
                btnEliminar.Visible = true;
                btnAbastecer.Visible = true;
            }
            else
            {
                btnEliminar.Visible = false;
                btnAbastecer.Visible = true;
                MessageBox.Show("Libro no encontrado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var logica = new LibroLogica();
            logica.EliminarLibro(txtISBN.Text.Trim());
            MessageBox.Show("Libro eliminado correctamente");
            txtISBN.Clear();
            txtTitulo.Clear();
            txtCompra.Clear();
            txtVenta.Clear();
            txtCantidad.Clear();
            btnEliminar.Visible = false;
            btnAbastecer.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var logica = new LibroLogica();
            var libro = new Libro
            {
                ISBN = txtISBN.Text.Trim(),
                Titulo = txtTitulo.Text.Trim(),
                PrecioCompra = decimal.Parse(txtCompra.Text.Trim()),
                PrecioVenta = decimal.Parse(txtVenta.Text.Trim()),
                CantidadActual = int.Parse(txtCantidad.Text.Trim())
            };
            if (logica.ActualizarLibro(libro, "Abastecimiento"))
            {
                txtISBN.Clear();
                txtTitulo.Clear();
                txtCompra.Clear();
                txtVenta.Clear();
                txtCantidad.Clear();
                btnEliminar.Visible = false;
                btnAbastecer.Visible = false;
                MessageBox.Show("Libro actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar el libro");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            var logica = new LibroLogica();
            var libro = new Libro
            {
                ISBN = txtISBN.Text.Trim(),
                Titulo = txtTitulo.Text.Trim(),
                PrecioCompra = decimal.Parse(txtCompra.Text.Trim()),
                PrecioVenta = decimal.Parse(txtVenta.Text.Trim()),
                CantidadActual = int.Parse(txtCantidad.Text.Trim())
            };
            if (logica.ActualizarLibro(libro, "Vender"))
            {
                txtISBN.Clear();
                txtTitulo.Clear();
                txtCompra.Clear();
                txtVenta.Clear();
                txtCantidad.Clear();
                btnEliminar.Visible = false;
                btnAbastecer.Visible = false;
                MessageBox.Show("Libro actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar el libro");
            }
        }
    }
}
