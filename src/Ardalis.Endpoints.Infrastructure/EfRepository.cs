using Ardalis.Endpoints.Infrastructure.Data;
using Ardalis.Endpoints.SharedKernel.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;

namespace Ardalis.Endpoints.Infrastructure
{
    public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
    {
        private readonly AppDbContext dbContext;

        public EfRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
