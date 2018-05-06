using Shop.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("ProductCategories")]
   public class ProductCategori:Audiable
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        [Required]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrders { set; get; }
        [Required]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Products> Products { set; get; }
        public virtual IEnumerable<OrderDetails> OrderDetail { set; get; }
    }
}
