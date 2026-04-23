using System;
using System.Collections.Generic;

namespace PCEClient.Services
{
    public interface IManufacturerObserver
    {
        void OnManufacturersChanged();
    }

    public sealed class ManufacturerEventManager
    {
        private static readonly Lazy<ManufacturerEventManager> _instance =
            new Lazy<ManufacturerEventManager>(() => new ManufacturerEventManager());
        public static ManufacturerEventManager Instance => _instance.Value;

        private readonly List<IManufacturerObserver> _observers = new List<IManufacturerObserver>();

        private ManufacturerEventManager() { }

        public void Subscribe(IManufacturerObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Unsubscribe(IManufacturerObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAll()
        {
            foreach (var observer in _observers.ToArray())
            {
                try { observer.OnManufacturersChanged(); }
                catch (Exception) { }
            }
        }
    }
}
