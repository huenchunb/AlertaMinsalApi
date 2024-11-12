﻿using WebApiAlertaMinsal.Application.Common.Models;

namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<string?> GetUserNameAsync(string userId);

    Task<bool> IsInRoleAsync(string userId, string role);

    Task<bool> AuthorizeAsync(string userId, string policyName);

    Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password, string role);

    Task<Result> DeleteUserAsync(string userId);

    Task<List<RolDto>> GetRolesAsync(CancellationToken cancellationToken);

    Task<List<string>> GetUserRolesAsync(string userId);
}
