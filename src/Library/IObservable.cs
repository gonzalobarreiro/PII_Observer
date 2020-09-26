using System;

namespace Observer
{
    public interface IObservable
    {
        public Temperature Current {get; set;}
        void Subscribe (IObserver observer);
        void Unsubscribe (IObserver observer);
    }
}