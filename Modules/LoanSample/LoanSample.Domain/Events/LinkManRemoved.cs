using LoanSample.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanSample.Domain.Events
{
    public class LinkManRemoved :INotification
    {
        public Customer Customer { get; private set; }

        public LinkMan LinkMan { get; private set; }

        public LinkManRemoved(Customer customer, LinkMan linkMan)
        {
            Customer = customer;
            LinkMan = linkMan;
        }
    }
}
