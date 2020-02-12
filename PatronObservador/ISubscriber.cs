namespace PatronObserver
{
    /// <summary>
    /// Interfaz de los subscriptores.
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// Método a ejecutarse al ser avisado por el publicador.
        /// </summary>
        void Update();
    }
}
