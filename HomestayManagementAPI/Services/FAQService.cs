using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Services.Interface;

namespace HomestayManagementAPI.Services
{
    public class FAQService : IFAQService
    {
        private readonly IFAQRepository _repository;

        public FAQService(IFAQRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FAQ>> GetAllFAQ()
        {
            return await _repository.GetAllFAQ();
        }

        public async Task<FAQ> GetFAQById(int id)
        {
            return await _repository.GetFAQById(id);
        }

        public async Task<bool> AddFAQ(FAQ faq)
        {
            return await _repository.AddFAQ(faq);
        }

        public async Task<bool> UpdateFAQ(FAQ faq)
        {
            return await _repository.UpdateFAQ(faq);
        }

        public async Task<bool> DeleteFAQ(int id)
        {
            return await _repository.DeleteFAQ(id);
        }
    }
}
