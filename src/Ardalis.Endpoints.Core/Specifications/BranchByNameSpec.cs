using Ardalis.Endpoints.Core.Entities;
using Ardalis.Specification;

namespace Ardalis.Endpoints.Core.Specifications
{
    public class BranchByNameSpec : Specification<Branch>, ISingleResultSpecification
    {
        public BranchByNameSpec(string name)
        {
            Query.Where(x => x.Name == name)
                .OrderBy(x => x.Name);
        }
    }
}
