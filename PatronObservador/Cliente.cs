using System;
using Extra.PatronFactory;

namespace PatronObserver
{
    /// <summary>
    /// Clase para llamar a los métodos principales.
    /// </summary>
    public class Cliente
    {
        

        /// <summary>
        ///Aplicación principal.
        /// </summary>
        public void Main()
        {
            Console.WriteLine("\n*************** OBSERVER ***************");


            Publisher publisher = new Publisher();
            Console.WriteLine("Menú" +
                              "\n 1-Subir código\n 2-Agregar Notificador \n 3-Agregar compilador " +
                              "\n 4-Agregar ejecutor de pruebas unitarias \n 5-Agregar instalador");
            int option;

            do
            {
                Console.WriteLine("\n Seleccione la opción deseada...");
                option = Convert.ToInt32(Console.ReadLine());
                ISubscriberFactory factory = SelectFactory(option);

                if (factory == null) continue;

                ISubscriber subscriber = factory.CreateInstance();
                publisher.Subscribe(subscriber);

            } while (option != 1);

            publisher.NotifySubscribers();
            publisher.Reset();
        }

        /// <summary>
        /// Selector de fábricas.
        /// </summary>
        /// <param name="option">Opción del usuario.</param>
        /// <returns>Fabrica de subscriptores.</returns>
        private ISubscriberFactory SelectFactory(int option)
        {
            switch (option)
            {
                case 2:
                    return new NotificadorFactory();
                case 3:
                    return new CompiladorFactory();
                case 4:
                    return new PruebasFactory();
                case 5:
                    return new InstaladorFactory();
                default:
                    return null;
            }
        }
    }
}
