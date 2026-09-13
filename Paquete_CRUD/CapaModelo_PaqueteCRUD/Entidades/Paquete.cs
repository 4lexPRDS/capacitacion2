namespace CapaModelo_PaqueteCRUD.Entidades
{
    // POCO: representa una fila exacta de la tabla "paquete" de taller_mvc.
    public class Paquete
    {
        public int IdPaquete { get; set; }
        public int IdPedido { get; set; }
        public string CodigoRastreoPaquete { get; set; }
        public decimal PesoPaquete { get; set; }
        public decimal AltoPaquete { get; set; }
        public decimal AnchoPaquete { get; set; }
        public decimal LargoPaquete { get; set; }
        public string DescripcionPaquete { get; set; }
        public string FragilPaquete { get; set; }
        public decimal ValorDeclaradoPaquete { get; set; }
        public string TipoPaquete { get; set; }
        public string EstadoPaquete { get; set; }
    }
}
