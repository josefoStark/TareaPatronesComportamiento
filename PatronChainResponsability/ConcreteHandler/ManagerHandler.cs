using System;

namespace PatronChainResponsability
{
    /// <summary>
    /// Clase gerente.
    /// </summary>
    /// <seealso cref="PatronChainResponsability.BaseHandler" />
    public class ManagerHandler : BaseHandler
    {
        /// <summary>
        /// Condiciones de autorización. Compras mayores a $5,000 y menores a $10,000.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        public override void HandleRequest(Request request)
        {
            if (request.Amount > 5000 && request.Amount <= 10000)
            {
                Console.WriteLine($" {request.Description} AUTORIZADO por el Gerente");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
