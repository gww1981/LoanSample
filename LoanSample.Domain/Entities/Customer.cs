using LoanSample.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain.Entities
{
    public class Customer : AggregateRootWithEvents<Guid>
    {
        private readonly List<LinkMan> _linkMen;

        public string Name { get; set; }

        public string Address { get; set;  }

        public IReadOnlyCollection<LinkMan> LinkMen 
        {
            get { return _linkMen.AsReadOnly(); }
        }
        
        public Customer()
        {
            _linkMen = new List<LinkMan>();
        }

        public void AddLinkMan(LinkMan linkMan)
        {
            _linkMen.Add(linkMan);
            AddDomainEvent(new LinkManAdded(this, linkMan));
        }

        public void RemoveLinkMan(LinkMan linkMan)
        {
            _linkMen.Remove(linkMan);
            RemoveDomainEvent(new LinkManRemoved(this, linkMan));
        }
    }
}
