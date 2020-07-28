using System;
using System.Collections.Generic;
using System.Text;

namespace LoanSample.Application.Contracts.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<LinkManDto> linkMen { get; set; }
    }
}
