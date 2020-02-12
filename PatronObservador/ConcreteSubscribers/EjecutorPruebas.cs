using System;

namespace PatronObserver
{
    /// <summary>
    /// Ejecutor de pruebas.
    /// </summary>
    /// <seealso cref="PatronObservador.ISubscriber" />
    public class EjecutorPruebas : ISubscriber
    {
        /// <summary>
        /// Método a ejecutarse al ser avisado por el publicador..
        /// </summary>
        public void Update()
        {
            Console.WriteLine("4. Todas las pruebas unitarias fueron exitosas.");
        }
    }
}
