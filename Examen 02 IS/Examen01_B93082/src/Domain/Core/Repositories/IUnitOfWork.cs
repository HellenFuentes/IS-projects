using System;
using System.Threading;
using System.Threading.Tasks;

namespace Examen01_B93082.Domain.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        void RollbackTransaction();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
