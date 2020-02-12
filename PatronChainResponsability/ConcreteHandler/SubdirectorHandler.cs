using System;

namespace PatronChainResponsability
{
    /// <summary>
    /// Clase subdirector.
    /// </summary>
    /// <seealso cref="PatronChainResponsability.BaseHandler" />
    public class SubdirectorHandler : BaseHandler
    {
        /// <summary>
        /// Condiciones de autorización. Compras mayores a $10,0000 y menores a $15,000.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        public override void HandleRequest(Request request)
        {
            if (request.Amount > 10000 && request.Amount <= 15000)
            {
                Console.WriteLine($" {request.Description} AUTORIZADO por el Subdirector");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
