using PatronObserver;

namespace Extra.PatronFactory
{
    /// <summary>
    /// Fabrica de compiladores.
    /// </summary>
    /// <seealso cref="Extra.PatronFactory.ISubscriberFactory" />
    public class CompiladorFactory : ISubscriberFactory
    {
        /// <summary>
        /// Crea una nueva instancia de un subscriptor.
        /// </summary>
        /// <returns>
        /// Compilador.
        /// </returns>
        public ISubscriber CreateInstance()
        {
            return new Compilador();
        }
    }
}
