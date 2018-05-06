using Shop.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{ [Table("PostCategories")]
   public class PostCategory:Audiable
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public int ParentID { set; get; }
        public int DisplayOrders { set; get; }
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
