namespace PatronStrategy
{
    /// <summary>
    /// Interfaz de las estrategias.
    /// </summary>
    public interface IStrategy
   {
        /// <summary>
        /// Estrategia para guardar la imagen.
        /// </summary>
        /// <param name="imagen">Imagen a guardar.</param>
        void Execute(Image imagen);
   }
}
