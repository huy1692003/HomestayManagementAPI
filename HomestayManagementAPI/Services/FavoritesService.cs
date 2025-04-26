using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Services.Interface;

namespace HomestayManagementAPI.Services
{
    public class FavoritesService:IFavoritesService
    {
        private readonly IFavoritesRepository _favoRes;
        public FavoritesService(IFavoritesRepository favoritesRepository)
        {
            _favoRes = favoritesRepository;
        }
        public async Task<bool> addFavorites(int idHomeStay, string idCus)
        {
            return await _favoRes.addFavorites(idHomeStay, idCus);
        }
        public async Task<bool> deleteFavorites(int id)
        {
            return await _favoRes.deleteFavorites(id);
        }
        public async Task<IEnumerable<dynamic>> getHomeStay_Favorites(string idCus)
        {
            return await _favoRes.getHomeStay_Favorites(idCus);
        }
    }
}
