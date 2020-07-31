using LoanSample.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain.Entities
{
    public class Customer : AggregateRootWithEvents<Guid>
    {

        public virtual string Name { get;  set; }

        public virtual string Address { get;  set;  }

        public virtual List<LinkMan> LinkMen 
        {
            get; set; 
        }

        protected Customer()
        {
            LinkMen = new List<LinkMan>();
        }

        public void AddLinkMan(LinkMan linkMan)
        {
            LinkMen.Add(linkMan);
            AddDomainEvent(new LinkManAdded(this, linkMan));
        }

        public void RemoveLinkMan(LinkMan linkMan)
        {
            LinkMen.Remove(linkMan);
            RemoveDomainEvent(new LinkManRemoved(this, linkMan));
        }
    }
}
