using System;
using C4.EventAggregator.Interfaces;

namespace C4.EventAggregator
{
    public class SimpleEventAggregator : IEventAggregator
    {
        public void Subscribe(object subscriber)
        {
            throw new NotImplementedException();
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            throw new NotImplementedException();
        }
    }
}
