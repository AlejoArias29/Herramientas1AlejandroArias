using modelo;
using System;
using System.Data.SqlClient;

namespace logica
{
    public class LibroLogica
    {
        string connection = "Server=DESKTOP-GFRLJV1;Database=TiendaLibros;Trusted_connection=True";

        public bool CrearLogica(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Libros (ISBN, Titulo, PrecioCompra, PrecioVenta, CantidadActual) VALUES (@isbn, @titulo, @pc, @pv, @cantidad)", conn);
                    cmd.Parameters.AddWithValue("@isbn", libro.ISBN);
                    cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@pc", libro.PrecioCompra);
                    cmd.Parameters.AddWithValue("@pv", libro.PrecioVenta);
                    cmd.Parameters.AddWithValue("@cantidad", libro.CantidadActual);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        public Libro BuscarLibro(string isbn, string titulo)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                var libro = new Libro();
                try
                {
                    string query = "";
                    if (!string.IsNullOrEmpty(isbn))
                    {
                        query = "SELECT * FROM Libros WHERE ISBN = @isbn";
                    }
                    else
                    {
                        query = "SELECT * FROM Libros WHERE Titulo = @titulo";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(isbn))
                    {
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                    }


                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            libro.ISBN = reader["ISBN"].ToString();
                            libro.Titulo = reader["Titulo"].ToString();
                            libro.PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]);
                            libro.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                            libro.CantidadActual = Convert.ToInt32(reader["CantidadActual"]);
                        }
                    }
                    conn.Close();
                    return libro;
                }
                catch (Exception)
                {
                    conn.Close();
                    return null;
                }
            }
        }

        public bool EliminarLibro(string isbn)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Libros WHERE ISBN = @isbn", conn);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        public bool ActualizarLibro(Libro libro, string tipo)
        {

            if (string.IsNullOrEmpty(libro.ISBN) && libro.CantidadActual > 0)
                return false;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Actualizar cantidad
                    string updateSql = "UPDATE Libros SET CantidadActual = CantidadActual + @cantidad WHERE ISBN = @isbn";
                    SqlCommand cmdUpdate = new SqlCommand(updateSql, conn, trans);
                    cmdUpdate.Parameters.AddWithValue("@cantidad", libro.CantidadActual);
                    cmdUpdate.Parameters.AddWithValue("@isbn", libro.ISBN);
                    int updated = cmdUpdate.ExecuteNonQuery();

                    if (updated == 0)
                        trans.Rollback();

                    // Insertar transacción
                    string insertSql = "INSERT INTO Transacciones (ISBN, Tipo, Fecha, Cantidad) VALUES (@isbn, @tipo, GETDATE(), @cantidad)";
                    SqlCommand cmdInsert = new SqlCommand(insertSql, conn, trans);
                    cmdInsert.Parameters.AddWithValue("@isbn", libro.ISBN);
                    cmdInsert.Parameters.AddWithValue("@tipo", tipo);
                    cmdInsert.Parameters.AddWithValue("@cantidad", libro.CantidadActual);
                    cmdInsert.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
    }
}
