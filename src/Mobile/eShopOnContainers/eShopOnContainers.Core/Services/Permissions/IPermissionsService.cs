using System.Collections.Generic;
using System.Threading.Tasks;
using bliztafree.Core.Models.Permissions;

namespace bliztafree.Core.Services.Permissions
{
    public interface IPermissionsService
    {
        Task<PermissionStatus> CheckPermissionStatusAsync(Permission permission);
        Task<Dictionary<Permission, PermissionStatus>> RequestPermissionsAsync(params Permission[] permissions);
    }
}
