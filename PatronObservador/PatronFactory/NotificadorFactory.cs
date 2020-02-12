using PatronObserver;

namespace Extra.PatronFactory
{
    /// <summary>
    /// Fábrica de notificadores.
    /// </summary>
    /// <seealso cref="Extra.PatronFactory.ISubscriberFactory" />
    public class NotificadorFactory : ISubscriberFactory
    {
        /// <summary>
        /// Crea una nueva instancia de un subscriptor.
        /// </summary>
        /// <returns>
        /// Notificador.
        /// </returns>
        public ISubscriber CreateInstance()
        {
            return new Notificador();
        }
    }
}
