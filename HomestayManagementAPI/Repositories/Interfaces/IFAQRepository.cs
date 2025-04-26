using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.Repositories.Interfaces
{
    public interface IFAQRepository
    {
        Task<IEnumerable<FAQ>> GetAllFAQ();
        Task<FAQ?> GetFAQById(int id);
        Task<bool> AddFAQ(FAQ faq);
        Task<bool> UpdateFAQ(FAQ faq);
        Task<bool> DeleteFAQ(int id);
    }
}
