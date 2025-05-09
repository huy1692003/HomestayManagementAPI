﻿using HomestayManagementAPI.DTOs;
using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.Services.Interface
{
    public interface IUserService
    {
        Task<bool> addUser(User user, int typeUser , string roleID="");
        Task<bool> addAdmin(RegisterAdminDTO res);
        Task<bool> changePassWord(string userID, string passOld, string passNew);
        Task<bool> updateProfile(User user);
        Task<bool> lockUser(User user);
        Task<LoginUserResDTO?> loginUser(string username, string password);
        Task<LoginUserResDTO?> loginAdmin(string username, string password);

        //private string GenerateJwtToken(User user);
    }
}
