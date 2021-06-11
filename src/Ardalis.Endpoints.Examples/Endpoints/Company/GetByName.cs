using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Ardalis.Endpoints.Core.Entities;
using Ardalis.Endpoints.Core.Specifications;
using Ardalis.Endpoints.Examples.Dtos;
using Ardalis.Endpoints.SharedKernel.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Ardalis.Endpoints.Examples.Endpoints
{
    public class GetByName : BaseAsyncEndpoint
        .WithRequest<ListCompanyRequest>
        .WithResponse<ListCompanyResponse>
    {
        private readonly IReadRepository<Company> _repository;
        private readonly IMapper _mapper;

        public GetByName(IReadRepository<Company> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("api/companies/GetByName")]
        [SwaggerOperation(
            Summary = "Get By Name Companies",
            Description = "Get By Name Companies",
            OperationId = "companies.GetByName",
            Tags = new[] { "CompanyEndpoints" })
        ]
        public override async Task<ActionResult<ListCompanyResponse>> HandleAsync([FromQuery] ListCompanyRequest request,
            CancellationToken cancellationToken)
        {
            var response = new ListCompanyResponse(request.CorrelationId());

            var spec = new CompanyByNameSpec(request.Name);
            var companies = await _repository.ListAsync(spec, cancellationToken);

            response.Companies = _mapper.Map<List<CompanyDto>>(companies);
            response.Count = response.Companies.Count;

            return Ok(response);
        }
    }
}
