using HomestayManagementAPI.DTOs;
using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Intefaces;
using HomestayManagementAPI.Services.Interface;

namespace HomestayManagementAPI.Services
{
    public class HomeStayService : IHomeStayService
    {
        private readonly IHomeStayRepository _homeStayRepository;

        public HomeStayService(IHomeStayRepository homeStayRepository)
        {
            _homeStayRepository = homeStayRepository;
        }
        public async Task<IEnumerable<HomeStayResDTO?>> getHomeStay()
        {
            return await _homeStayRepository.getHomeStay();
        }
        public async Task<IEnumerable<HomeStayResDTO?>> getHomeStayViewHight()
        {
            return await _homeStayRepository.getHomeStayViewHight();
        }
        public async Task<PagedResultDTO<HomeStayResDTO?>> searchHomeStayByCustomer(SearchHomeStayDTO search, PaginateDTO paginate)
        {
            return await _homeStayRepository.searchHomeStayByCustomer(search, paginate);
        }
        public async Task<HomeStayDetailDTO?> getHomeStayByID(int ID)
        {
            return await _homeStayRepository.getHomeStayByID(ID);
        }
        public async Task<bool> addHomeStay(HomeStayReqDTO homeStay)
        {
            return await _homeStayRepository.addHomeStay(homeStay);
        }
        public async Task<bool> updateHomeStay(HomeStayReqDTO homeStay)
        {
            return await _homeStayRepository.updateHomeStay(homeStay);
        }
        public async Task<bool> deleteHomeStay(int ID)
        {
            return await _homeStayRepository.deleteHomeStay(ID);
        }
        public async Task<bool> lockHomeStay(int ID)
        {
            return await _homeStayRepository.deleteHomeStay(ID);
        }

    }
}
