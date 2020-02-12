using PatronStrategy;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón strategy.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Strategy : IPattern
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
