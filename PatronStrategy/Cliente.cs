using System;

namespace PatronStrategy
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
            Console.WriteLine("\n*************** STRATEGY ***************");

            Console.WriteLine("\n Ingrese el nombre de la imagen...");
            string nameImage = Console.ReadLine();

            Console.WriteLine("\n Seleccione el formato " +
                              "\n 1-BMP\n 2-PNG \n 3-JPEG");

            int option = Convert.ToInt32(Console.ReadLine());

            IStrategy bmpStrategy = SelectStrategy(option);

            if (bmpStrategy == null) return;

            Context context = new Context();
            context.SetStrategy(bmpStrategy);
            context.SaveImage(nameImage);

        }

        /// <summary>
        /// Selector de estrategia.
        /// </summary>
        /// <param name="option">Opción del usuario.</param>
        /// <returns>Estrategia.</returns>
        private IStrategy SelectStrategy(int option)
        {
            switch (option)
            {
                case 1:
                    return new SaveBMP();
                case 2:
                    return new SavePNG();
                case 3:
                    return new SaveJPEG();
                default:
                    return null;
            }
        }
    }
}
