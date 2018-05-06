using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { set; get; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        public string Quantily { set; get; }
        [ForeignKey("OrderID")]
        
        public virtual Orders Orders { set; get; }
        [ForeignKey("ProductID")]

        public virtual ProductCategori ProductCategori { set; get; }
    }
}