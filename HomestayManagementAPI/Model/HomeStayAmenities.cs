using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomestayManagementAPI.Model
{
    [Table("HomeStayAmenities")]
    public class HomeStayAmenities
    {
        [Column("id")]
        public int? id { get; set; }

        
        [Column("homestayID")]
        public int? HomestayID { get; set; }

        
        [Column("amenityID")]
        public int AmenityID { get; set; }
    }

}
