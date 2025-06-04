using System;

namespace modelo
{
    public class Transaccion
    {
        public int IdTransaccion { get; set; }
        public string ISBN { get; set; }
        public string TipoTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }

}
