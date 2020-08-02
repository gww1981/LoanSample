using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain.Entities
{
    public class LinkMan : Entity<Guid>
    {
        protected LinkMan() { }

        public LinkMan (Guid guid)
            :base(guid)
        {

        }
        public virtual string Name { get;  set; }

        public virtual string Mobile { get;  set; }

        public virtual string IdNo { get;  set; }
    }
}
