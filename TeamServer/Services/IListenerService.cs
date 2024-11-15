﻿using TeamServer.Models;

namespace TeamServer.Services
{
    public interface IListenerService
    {
        void AddListener(Listener listener);
        IEnumerable<Listener> GetListeners();
        Listener ?GetListener(string name);
        void RemoveListener(Listener listener);
        void AddListener(System.Net.HttpListener listener);
    }
    public class ListenerService : IListenerService
    {

        private readonly List<Listener> _listeners = new();
        public void AddListener(Listener listener)
        {
            _listeners.Add(listener);
        }

        public void AddListener(System.Net.HttpListener listener)
        {
            throw new NotImplementedException();
        }

        //public Listener GetListener(string name)
        //{
        //  return GetListeners().FirstOrDefault(l => l.Name.Equals(name));
        //}

        public Listener? GetListener(string name)  // Allow null return value
        {
            return GetListeners().FirstOrDefault(l => l.Name.Equals(name));
        }

        public IEnumerable<Listener> GetListeners()
        {
            return _listeners;
        }

        public void RemoveListener(Listener listener)
        {
            _listeners.Remove(listener);
        }
    }
}
