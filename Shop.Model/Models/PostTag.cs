﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
   [ Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }
        [Key]
        public string TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tags Tags { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
    }
}
