using System;

namespace PatronObserver
{
    /// <summary>
    /// Notificador
    /// </summary>
    /// <seealso cref="PatronObservador.ISubscriber" />
    public class Notificador : ISubscriber
    {
        /// <summary>
        /// Método a ejecutarse al ser avisado por el publicador.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("2. Existe una actualización de código correcta.");
        }
    }
}
