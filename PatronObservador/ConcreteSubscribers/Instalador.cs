using System;

namespace PatronObserver
{
    /// <summary>
    /// Instalador
    /// </summary>
    /// <seealso cref="PatronObservador.ISubscriber" />
    public class Instalador : ISubscriber
    {
        /// <summary>
        /// Método a ejecutarse al ser avisado por el publicador.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("5. Se ha instalado la versión 1.1.");
        }
    }
}
