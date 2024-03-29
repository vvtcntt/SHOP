﻿using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblImages")]
   public class Images:Auditable
    {
        public int idCate { set; get; }
        [ForeignKey("id")]
        public virtual GroupImage GroupImage { set; get; }
        [Required]
        [MaxLength(200)]
        public string Image { set; get; }
        [Required]
        [MaxLength(200)]
        public string Url { set; get; }
        public bool Link { set; get; }
        [Required]
        [MaxLength(100)]
        public string Color { set; get; }


    }
}
