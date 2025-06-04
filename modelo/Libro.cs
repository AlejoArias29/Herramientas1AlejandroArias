namespace modelo
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadActual { get; set; }
    }

}
