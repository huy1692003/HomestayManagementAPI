using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.DTOs
{
    public class HomeStayReqDTO
    {
        public HomeStay? HomeStay { get; set; }
        public int[]? ListAmenities { get; set; }
        public DetailHomeStay? DetailHomeStay { get; set; }
    }
}
