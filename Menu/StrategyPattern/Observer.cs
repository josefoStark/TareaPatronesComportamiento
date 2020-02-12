using PatronObserver;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón Observer.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Observer : IPattern
    {
        /// <summary>
        /// Ejecuta la aplicación correspondiente al patrón de diseño .
        /// </summary>
        public void Execute()
        {
            new Cliente().Main();
        }
    }
}
