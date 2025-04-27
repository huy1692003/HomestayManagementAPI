using HomestayManagementAPI.Model;

namespace HomestayManagementAPI.DTOs
{
    public class HomeStayResDTO
    {
        public HomeStay? HomeStay { get; set; }
        public DetailHomeStay? DetailHomeStay { get; set; }

        public User? Owner { get; set; }
    }
}
