using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("VisitorStatistics")]
   public  class VisitorStatistics
    {
        [Key]

        public Guid ID { set; get; }
    
        public DateTime? VisitedDate { set; get; }
        public string IPAddress { set; get; }
    }
}
