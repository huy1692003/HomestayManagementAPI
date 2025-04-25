using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.Repositories.Intefaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetAllRole();
        Task<Role?> GetRoleById(string roleId);
        Task<bool> AddRole(Role role);
        Task<bool> UpdateRole(Role role);
        Task<bool> DeleteRole(string roleId);
    }
}
