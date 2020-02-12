namespace PatronStrategy
{
    /// <summary>
    /// Estrategia JPEG.
    /// </summary>
    /// <seealso cref="PatronStrategy.IStrategy" />
    public class SaveJPEG : IStrategy
    {
        /// <summary>
        /// Estrategia para guardar la imagen.
        /// </summary>
        /// <param name="imagen">Imagen a guardar.</param>
        public void Execute(Image imagen)
        {
            imagen.Extension = "jpeg";
        }
    }
}
