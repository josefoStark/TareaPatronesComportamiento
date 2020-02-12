namespace PatronStrategy
{
    /// <summary>
    /// Imagen.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Image"/>.
        /// </summary>
        /// <param name="name">Nombre de la imagen..</param>
        public Image(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Nombre de la imagen.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Extensión de la imagen.
        /// </summary>
        public string Extension { get; set; }
    }
}
