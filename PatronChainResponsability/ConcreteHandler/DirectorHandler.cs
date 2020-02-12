using System;

namespace PatronChainResponsability
{
    /// <summary>
    /// Clase Director.
    /// </summary>
    /// <seealso cref="PatronChainResponsability.BaseHandler" />
    public class DirectorHandler : BaseHandler
    {
        /// <summary>
        /// Condiciones de autorización. Compras menores a $50,000.
        /// </summary>
        /// <param name="request">Solicitud de compra.</param>
        public override void HandleRequest(Request request)
        {
            Console.WriteLine(request.Amount < 50000
                ? $" {request.Description} AUTORIZADO por el Director"
                : $" {request.Description} DENEGADO");
        }
    }
}
