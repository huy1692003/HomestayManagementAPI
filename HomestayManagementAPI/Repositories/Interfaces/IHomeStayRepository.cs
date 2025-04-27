using HomestayManagementAPI.DTOs;
using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.Repositories.Intefaces
{
    public interface IHomeStayRepository
    {
        Task<IEnumerable<HomeStayResDTO?>> getHomeStay();
        Task<PagedResultDTO<HomeStayResDTO?>> searchHomeStayByCustomer(SearchHomeStayDTO search, PaginateDTO paginate);
        Task<HomeStayDetailDTO?> getHomeStayByID(int ID);
        Task<bool> addHomeStay(HomeStayReqDTO homeStay);
        Task<bool> updateHomeStay(HomeStayReqDTO homeStay);
        Task<bool> deleteHomeStay(int ID);
        Task<bool> lockHomeStay(int ID);

        Task<IEnumerable<HomeStayResDTO?>> getHomeStayViewHight();


    }
}
