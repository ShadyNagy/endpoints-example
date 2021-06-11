using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Ardalis.Endpoints.Core.Entities;
using Ardalis.Endpoints.Examples.Dtos;
using Ardalis.Endpoints.SharedKernel.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Ardalis.Endpoints.Examples.Endpoints
{
    public class List : BaseAsyncEndpoint
        .WithoutRequest
        .WithResponse<ListCompanyResponse>
    {
        private readonly IReadRepository<Company> _repository;
        private readonly IMapper _mapper;

        public List(IReadRepository<Company> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("api/companies")]
        [SwaggerOperation(
            Summary = "List Companies",
            Description = "List Companies",
            OperationId = "companies.List",
            Tags = new[] { "CompanyEndpoints" })
        ]
        public override async Task<ActionResult<ListCompanyResponse>> HandleAsync(CancellationToken cancellationToken)
        {
            var response = new ListCompanyResponse(Guid.NewGuid());

            var companies = await _repository.ListAsync(cancellationToken);

            response.Companies = _mapper.Map<List<CompanyDto>>(companies);
            response.Count = response.Companies.Count;

            return Ok(response);
        }
    }
}
