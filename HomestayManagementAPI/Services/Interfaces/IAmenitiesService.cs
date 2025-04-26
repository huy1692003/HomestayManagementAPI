using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.Services.Interfaces
{
    public interface IAmenitiesService
    {
        Task<IEnumerable<Amenities>> GetAllAmenitiesAsync();
        Task<Amenities?> GetAmenityByIdAsync(int id);
        Task<bool> AddAmenityAsync(Amenities amenity);
        Task<bool> UpdateAmenityAsync(Amenities amenity);
        Task<bool> DeleteAmenityAsync(int id);
        bool AmenityExists(int id);
    }
}
