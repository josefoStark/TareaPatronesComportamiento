using System;

namespace PatronChainResponsability
{
    /// <summary>
    /// Clase coordinador.
    /// </summary>
    /// <seealso cref="PatronChainResponsability.BaseHandler" />
    public class CoordinatorHandler : BaseHandler
    {
        /// <summary>
        /// Condiciones de autorización. Compras menores a $5,000.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        public override void HandleRequest(Request request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($" {request.Description} AUTORIZADO por el Coordinador");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
