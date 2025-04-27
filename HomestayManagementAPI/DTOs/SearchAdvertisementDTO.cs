namespace HomestayManagementAPI.DTOs
{
    public class SearchAdvertisementDTO
    {
        public string? Title { get; set; }
        public int? Placement { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
