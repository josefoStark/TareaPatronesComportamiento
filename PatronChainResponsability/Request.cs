namespace PatronChainResponsability
{
    /// <summary>
    /// Solicitud de compra.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Precio de la compra..
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Descripción de la compra.
        /// </summary>
        public string Description { get; set; }
    }
}
