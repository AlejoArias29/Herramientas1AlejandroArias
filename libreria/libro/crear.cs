using logica;
using modelo;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace libreria
{
    public partial class crear : Form
    {
        public crear()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var libro = new Libro
            {
                ISBN = txtISBN.Text,
                Titulo = txtTitulo.Text,
                PrecioCompra = decimal.Parse(txtCompra.Text),
                PrecioVenta = decimal.Parse(txtVenta.Text),
                CantidadActual = int.Parse(txtCantidad.Text)
            };
            var logica = new LibroLogica();
            if (logica.CrearLogica(libro))
            {
                MessageBox.Show("Libro registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el libro. Verifique los datos e intente nuevamente.");
            }
        }
    }
}
