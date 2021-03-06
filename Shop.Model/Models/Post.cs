﻿using Shop.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Posts")]
    public class Post:Audiable
    {
        [Key]
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public string Image { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
        public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}
