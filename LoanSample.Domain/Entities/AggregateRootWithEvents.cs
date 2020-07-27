using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain.Entities
{

    public interface IHasDomainEvent
    {
        void AddDomainEvent(INotification eventItem);
        void RemoveDomainEvent(INotification eventItem);

        void ClearDomainEvents();
    }

    public class AggregateRootWithEvents<TKey> : AggregateRoot<TKey>, IHasDomainEvent
    {
        private List<INotification> _domainEvents;

        public IReadOnlyCollection<INotification> DomainEvents =>_domainEvents?.AsReadOnly();

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }
    }
}
