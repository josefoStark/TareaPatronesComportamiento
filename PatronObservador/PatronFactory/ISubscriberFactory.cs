using PatronObserver;

namespace Extra.PatronFactory
{
    /// <summary>
    /// Interfaz de la fabrica de subscriptores
    /// </summary>
    public interface ISubscriberFactory
    {
        /// <summary>
        /// Crea una nueva instancia de un subscriptor.
        /// </summary>
        /// <returns>Subscriptor.</returns>
        ISubscriber CreateInstance();
    }
}
