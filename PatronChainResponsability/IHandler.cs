namespace PatronChainResponsability
{
    /// <summary>
    /// Interfaz para los puestos que autorizan
    /// </summary>
    public interface IHandler
    {
        /// <summary>
        /// Establece el siguiente puesto que autoriza.
        /// </summary>
        /// <param name="handler">Puesto.</param>
        /// <returns></returns>
        IHandler SetNext(IHandler handler);

        /// <summary>
        /// Autoriza o no la solicitud de compra.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        void HandleRequest(Request request);
    }
}
