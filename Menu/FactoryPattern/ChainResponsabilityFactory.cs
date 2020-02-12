using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de ChainResponsability.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class ChainResponsabilityFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new ChainResponsability();
        }
    }
}
