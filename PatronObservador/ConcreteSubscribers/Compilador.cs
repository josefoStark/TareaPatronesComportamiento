using System;

namespace PatronObserver
{
    /// <summary>
    /// Compilador.
    /// </summary>
    /// <seealso cref="PatronObservador.ISubscriber" />
    public class Compilador : ISubscriber
    {
        /// <summary>
        /// Método a ejecutarse al ser avisado por el publicador..
        /// </summary>
        public void Update()
        {
            Console.WriteLine("3. Compilación de código correcta.");
        }
    }
}
