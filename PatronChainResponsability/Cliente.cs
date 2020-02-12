using System;

namespace PatronChainResponsability
{
    /// <summary>
    /// Clase para llamar a los métodos principales.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Aplicación principal.
        /// </summary>
        public void Main()
        {
            Console.WriteLine("\n*************** CHAIN RESPONSABILITY ***************");
            Request request = BuildRequest();

            IHandler coordinator = new CoordinatorHandler();
            IHandler manager = new ManagerHandler();
            IHandler subdirector = new SubdirectorHandler();
            IHandler director = new DirectorHandler();

            coordinator.SetNext(manager);
            manager.SetNext(subdirector);
            subdirector.SetNext(director);

            coordinator.HandleRequest(request);
        }

        /// <summary>
        /// Construye la solicitud de compra.
        /// </summary>
        /// <returns>Solicitud de compra</returns>
        private Request BuildRequest()
        {
            Console.WriteLine("\nIngrese concepto de la solicitud de compra.");
            string concepto = Console.ReadLine();

            Console.WriteLine("\nIngrese cantidad de la solicitud.");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            Request request = new Request
            {
                Amount = cantidad,
                Description = concepto
            };

            return request;
        }
    }
}
