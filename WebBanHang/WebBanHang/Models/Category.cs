using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Category
    {
        [Key]
        public int CateID { get; set; }
        public String CateName { get; set; }


        public virtual List<Product> Products { get; set; }
    }
}