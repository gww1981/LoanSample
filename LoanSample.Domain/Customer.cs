using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain
{
    public class Customer : AggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Address { get; set;  }

        public ICollection<LinkMan> linkMen { get; set; }



    }
}
