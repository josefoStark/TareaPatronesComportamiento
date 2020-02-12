using System;
using System.Collections.Generic;
using System.Linq;

namespace PatronObserver
{
    /// <summary>
    /// Publicador.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Lista de subscriptores.
        /// </summary>
        private readonly List<ISubscriber> _lstSubscribers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Publisher"/> class.
        /// </summary>
        public Publisher()
        {
            _lstSubscribers = new List<ISubscriber>();
        }

        /// <summary>
        /// Subscribe a un nuevo miembro.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        public void Subscribe(ISubscriber subscriber)
        {
            string name = nameof(subscriber.GetType);

            if (!_lstSubscribers.Select(x => x.GetType().Name).Contains(name))
                _lstSubscribers.Add(subscriber);
        }

        /// <summary>
        /// Notifica a todos los subscriptores..
        /// </summary>
        public void NotifySubscribers()
        {
            Console.WriteLine("\n1. Commit de código de la versión 1.1");
            _lstSubscribers.ForEach(subscriber => subscriber.Update());
        }

        /// <summary>
        /// Desuscribe a todos los miembros.
        /// </summary>
        public void Reset()
        {
            _lstSubscribers.Clear();
        }
    }
}
