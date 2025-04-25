using HomestayManagementAPI.Data;
using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomestayManagementAPI.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DBContext _context;

        public RoleRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRole()
        {
            // Bước 1: Lấy dữ liệu cơ bản từ database
            var roles = await _context.Roles
                .Select(role => new Role
                {
                    RoleID = role.RoleID,
                    NameRole = role.NameRole,
                    Permission = role.Permission,
                    listMenus = new List<int>()
                })
                .ToListAsync();

            // Bước 2: Xử lý listMenus sau khi đã lấy dữ liệu về
            return roles.Select(role =>
            {
                role.listMenus = string.IsNullOrEmpty(role.Permission)
                    ? new List<int>()
                    : JsonSerializer.Deserialize<List<int>>(role.Permission);
                return role;
            });
        }

        public async Task<Role?> GetRoleById(string roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            role!.listMenus = string.IsNullOrEmpty(role.Permission)
                    ? new List<int>() // Nếu Permission là null hoặc rỗng, tạo list rỗng
                    : JsonSerializer.Deserialize<List<int>>(role.Permission); // Chuyển chuỗi JSON thành List<int>

            return role;
        }

        public async Task<bool> AddRole(Role role)
        {
            role.RoleID = Guid.NewGuid().ToString(); // Tạo ID ngẫu nhiên cho vai trò
            await _context.Roles.AddAsync(role);
            return await _context.SaveChangesAsync() > 0; // Trả về true nếu thêm thành công
        }

        public async Task<bool> UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            return await _context.SaveChangesAsync() > 0; // Trả về true nếu cập nhật thành công
        }

        public async Task<bool> DeleteRole(string roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role != null)
            {
                _context.Roles.Remove(role);
                return await _context.SaveChangesAsync() > 0; // Trả về true nếu xóa thành công
            }
            return false; // Vai trò không tồn tại
        }
    }
}
