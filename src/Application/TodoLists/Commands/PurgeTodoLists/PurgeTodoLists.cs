﻿using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.TodoLists.Commands.PurgeTodoLists;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeTodoListsCommand : IRequest;

public class PurgeTodoListsCommandHandler : IRequestHandler<PurgeTodoListsCommand>
{
    private readonly IApplicationDbContext _context;

    public PurgeTodoListsCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(PurgeTodoListsCommand request, CancellationToken cancellationToken)
    {
        _context.TodoList.RemoveRange(_context.TodoList);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
