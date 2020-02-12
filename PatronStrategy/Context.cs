using System;

namespace PatronStrategy
{
    /// <summary>
    /// Contexto.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Estrategia
        /// </summary>
        private IStrategy _strategy;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Context"/>.
        /// </summary>
        public Context()
        {
            _strategy = new SaveBMP();
        }

        /// <summary>
        /// Establece una nueva estrategia.
        /// </summary>
        /// <param name="strategy">Estrategia seleccionada.</param>
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Guardar la imagen.
        /// </summary>
        /// <param name="nameImage">Imagen a guardar.</param>
        public void SaveImage(string nameImage)
        {
            Image image = new Image(nameImage);
            _strategy.Execute(image);
            Console.WriteLine($"Se ha guardado la imagen {image.Name}.{image.Extension}");
        }
    }
}
