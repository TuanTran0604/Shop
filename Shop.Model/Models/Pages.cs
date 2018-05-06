using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Pages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Content { set; get; }

        [Required]
        public string MetaKeyword { set; get; }

        [Required]
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}