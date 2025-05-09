﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomestayManagementAPI.Model
{
    [Table("Amenities")]
    public class Amenities
    {
        [Key]
        [Column("amenityID")]
        public int? AmenityID { get; set; }

        [Column("name")]
        public string? Name { get; set; } 
        [Column("icon")]
        public string? icon { get; set; }

       
    }

}
