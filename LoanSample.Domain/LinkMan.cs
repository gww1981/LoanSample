﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Domain
{
    public class LinkMan : Entity<Guid>
    {
        public string Name { get; set; }

        public string Mobile { get; set; }


    }
}
