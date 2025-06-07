using modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public  class TransaccionLogica
    {
        string connection = "Server=DESKTOP-GFRLJV1;Database=TiendaLibros;Trusted_connection=True";

        public int BuscarTransaccion(Libro libro)
        {
            int transacciones = 0;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Transacciones WHERE ISBN = @isbn AND Tipo = 'Abastecimiento'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@isbn", libro.ISBN);

                    conn.Open();
                    int total = (int)cmd.ExecuteScalar();
                    transacciones = total;
                    conn.Close();
                    return transacciones;
                }
                catch (Exception)
                {
                    conn.Close();
                    return transacciones;
                }
            }
        }

        public Libro BuscarLibroMasMenosCostosoLogica(string query)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                var libro = new Libro();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        libro.ISBN = reader["ISBN"].ToString();
                        libro.Titulo = reader["Titulo"].ToString();
                        libro.PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]);
                        libro.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                        libro.CantidadActual = Convert.ToInt32(reader["CantidadActual"]);
                    }
                    conn.Close();
                    return libro;
                }
                catch (Exception)
                {
                    conn.Close();
                    return libro;
                }
            }
        }
    }
}
