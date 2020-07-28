using LoanSample.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanSample.Domain.Events
{
    public class LinkManAdded : INotification
    {
        public Customer Customer { get; private set; }

        public LinkMan LinkMan { get; private set; }

        public LinkManAdded (Customer customer,LinkMan linkMan)
        {
            Customer = customer;
            LinkMan = linkMan;
        }
    }
}
