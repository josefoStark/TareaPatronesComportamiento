namespace PatronStrategy
{
    /// <summary>
    /// Estrategia PNG.
    /// </summary>
    /// <seealso cref="PatronStrategy.IStrategy" />
    public class SavePNG : IStrategy
    {
        /// <summary>
        /// Estrategia para guardar la imagen.
        /// </summary>
        /// <param name="imagen">Imagen a guardar.</param>
        public void Execute(Image imagen)
        {
            imagen.Extension = "png";
        }
    }
}
