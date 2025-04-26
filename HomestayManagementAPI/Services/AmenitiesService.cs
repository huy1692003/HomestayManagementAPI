using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Services.Interfaces;

namespace HomestayManagementAPI.Services
{
    public class AmenitiesService : IAmenitiesService
    {
        private readonly IAmenitiesRepository _repository;

        public AmenitiesService(IAmenitiesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Amenities>> GetAllAmenitiesAsync()
        {
            return await _repository.GetAllAmenitiesAsync();
        }

        public async Task<Amenities?> GetAmenityByIdAsync(int id)
        {
            return await _repository.GetAmenityByIdAsync(id);
        }

        public async Task<bool> AddAmenityAsync(Amenities amenity)
        {
            return await _repository.AddAmenityAsync(amenity);  // Trả về true/false dựa vào kết quả thêm
        }

        public async Task<bool> UpdateAmenityAsync(Amenities amenity)
        {
           
            return await _repository.UpdateAmenityAsync(amenity);  // Trả về true/false dựa vào kết quả cập nhật
        }

        public async Task<bool> DeleteAmenityAsync(int id)
        {
            
            return await _repository.DeleteAmenityAsync(id);  // Trả về true/false dựa vào kết quả xóa
        }

        public bool AmenityExists(int id)
        {
            return _repository.AmenityExists(id);
        }
    }
}
