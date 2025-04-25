using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomestayManagementAPI.Model
{
    [Table("FAQs")]
    public class FAQ
    {
        [Key]
        [Column("faqID")]
        public int? FaqID { get; set; }

        [Column("question")]
        public string? Question { get; set; }

        [Column("answer")]
        public string? Answer { get; set; }

        [Column("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [Column("updatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("authorID")]
        public string? AuthorID { get; set; }
    }

}
