using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Comuna> Comunas { get; }
    DbSet<Region> Regiones { get; }
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
