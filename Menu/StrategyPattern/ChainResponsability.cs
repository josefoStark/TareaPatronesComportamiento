using  PatronChainResponsability;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón ChainResponsability
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class ChainResponsability : IPattern
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
