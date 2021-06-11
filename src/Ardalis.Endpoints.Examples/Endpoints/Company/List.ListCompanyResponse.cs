using System;
using System.Collections.Generic;
using Ardalis.Endpoints.Examples.Dtos;

namespace Ardalis.Endpoints.Examples.Endpoints
{
    public class ListCompanyResponse: BaseResponse
    {
        public ListCompanyResponse(Guid correlationId) : base(correlationId)
        {
        }

        public List<CompanyDto> Companies { get; set; }
        public int Count { get; set; }
    }
}
