using Shop.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shop.Model.Models
{ [Table("Products")]
    public class Products:Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
       
        public string Image { set; get;}
        
        public XElement MoreImage { set; get; }
      
        public string Description { set; get; }
        public int? Warranty { set; get; }
        
        public decimal? Promotion { set; get; }
       
        public decimal? Price { set; get; }
        [Required]
        public string Content { set; get; }
        [Required]
        public bool HomeFlag { set; get; }
        [Required]
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategori ProductCategory { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

    }
}
