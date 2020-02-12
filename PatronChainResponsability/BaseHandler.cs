namespace PatronChainResponsability
{
    /// <summary>
    /// Clase abstracta para los puestos que autorizan.
    /// </summary>
    /// <seealso cref="PatronChainResponsability.IHandler" />
    public abstract class BaseHandler : IHandler
    {
        /// <summary>
        /// Siguiente puesto en autorizar.
        /// </summary>
        protected IHandler _nextHandler;

        /// <summary>
        /// Establece el puesto siguiente en autorizar.
        /// </summary>
        /// <param name="handler">Puesto que autoriza.</param>
        /// <returns></returns>
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }

        /// <summary>
        /// Condiciones de autorización.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        public virtual void HandleRequest(Request request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
