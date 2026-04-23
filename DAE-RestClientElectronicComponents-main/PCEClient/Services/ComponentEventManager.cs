using System;
using System.Collections.Generic;

namespace PCEClient.Services
{
    public interface IComponentObserver
    {
        void OnComponentsChanged();
    }

    public sealed class ComponentEventManager
    {
        private static readonly Lazy<ComponentEventManager> _instance =
            new Lazy<ComponentEventManager>(() => new ComponentEventManager());
        public static ComponentEventManager Instance => _instance.Value;

        private readonly List<IComponentObserver> _observers = new List<IComponentObserver>();

        private ComponentEventManager() { }

        public void Subscribe(IComponentObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Unsubscribe(IComponentObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAll()
        {
            foreach (var observer in _observers.ToArray())
            {
                try
                {
                    observer.OnComponentsChanged();
                }
                catch (Exception)
                {
                    // Observer may have been disposed
                }
            }
        }
    }
}
