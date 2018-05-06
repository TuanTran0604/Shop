using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Orders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { set; get; }
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerAddress { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        [Required]
        public string CustomerMobile { set; get; }
        [Required]
        public string CustomerMessage { set; get; }
        public DateTime CreatedDate { set; get; }
        [Required]
        public string CreatedBy { set; get; }
        [Required]
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }
        [Required]  
        public bool Status { set; get; }
        public virtual IEnumerable<OrderDetails> OrderDetails { set; get; }
    }
}