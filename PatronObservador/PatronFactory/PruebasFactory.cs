using PatronObserver;

namespace Extra.PatronFactory
{
    /// <summary>
    /// Fábrica de Ejecutor de pruebas.
    /// </summary>
    /// <seealso cref="Extra.PatronFactory.ISubscriberFactory" />
    public class PruebasFactory : ISubscriberFactory
    {
        /// <summary>
        /// Crea una nueva instancia de un subscriptor.
        /// </summary>
        /// <returns>
        /// Ejecutor de pruebas.
        /// </returns>
        public ISubscriber CreateInstance()
        {
            return new EjecutorPruebas();
        }
    }
}
