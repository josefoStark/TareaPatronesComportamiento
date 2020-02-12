using PatronObserver;

namespace Extra.PatronFactory
{
    /// <summary>
    /// Fábrica de instaladores.
    /// </summary>
    /// <seealso cref="Extra.PatronFactory.ISubscriberFactory" />
    public class InstaladorFactory : ISubscriberFactory
    {
        /// <summary>
        /// Crea una nueva instancia de un subscriptor.
        /// </summary>
        /// <returns>
        /// Instalador.
        /// </returns>
        public ISubscriber CreateInstance()
        {
            return new Instalador();
        }
    }
}
