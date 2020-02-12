using System;
using Menu.FactoryPattern;
using Menu.StrategyPattern;

namespace Menu
{
    /// <summary>
    /// Clase para llamar a los métodos principales.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Aplicación principal.
        /// </summary>
        public void Main()
        {
            Console.WriteLine("\n Seleccione el patrón de diseño a ejecutar: " +
                                         "\n 1-ChainResponsability\n 2-Observer \n 3-Strategy");


            int option = Convert.ToInt32(Console.ReadLine());

            IFactory factory = SelectPatternFactory(option);

            if (factory == null) return;

            IPattern pattern = factory.GetInstance();

            Context context = new Context();
            context.SetPattern(pattern);
            context.ConsoleProgram();

        }

        /// <summary>
        /// Selecciona una fábrica de patrones.
        /// </summary>
        /// <param name="option">Opción del usuario.</param>
        /// <returns>Fabrica de patrones.</returns>
        private IFactory SelectPatternFactory(int option)
        {
            switch (option)
            {
                case 1:
                    return new ChainResponsabilityFactory();
                case 2:
                    return new ObserverFactory();
                case 3:
                    return new StrategyFactory();
                default:
                    return null;
            }
        }
    }
}
