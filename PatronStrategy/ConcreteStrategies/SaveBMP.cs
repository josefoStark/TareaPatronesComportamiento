namespace PatronStrategy
{
    /// <summary>
    /// Estrategia BMP.
    /// </summary>
    /// <seealso cref="PatronStrategy.IStrategy" />
    public class SaveBMP : IStrategy
    {
        /// <summary>
        /// Estrategia para guardar la imagen.
        /// </summary>
        /// <param name="imagen">Imagen a guardar.</param>
        public void Execute(Image imagen)
        {
            imagen.Extension = "bmp";
        }
    }
}
