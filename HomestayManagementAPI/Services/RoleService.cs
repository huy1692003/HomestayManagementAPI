using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Intefaces;
using HomestayManagementAPI.Services.Interface;

namespace HomestayManagementAPI.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllRole()
        {
            return await _roleRepository.GetAllRole();
        }

        public async Task<Role?> GetRoleById(string roleId)
        {
            return await _roleRepository.GetRoleById(roleId);
        }

        public async Task<bool> AddRole(Role role)
        {
            return await _roleRepository.AddRole(role);
        }

        public async Task<bool> UpdateRole(Role role)
        {
            return await _roleRepository.UpdateRole(role);
        }

        public async Task<bool> DeleteRole(string roleId)
        {
            return await _roleRepository.DeleteRole(roleId);
        }

    }
}
