﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class ProductHeadPhone
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int ID { get; set; }
        public string Jack { get; set; }
        public string Key { get; set; }
        public string OtherFeatures { get; set; }
        [ForeignKey("Product")]
        public int ProID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Company")]
        public int ComID { get; set; }
        public virtual Company Company { get; set; }
        [ForeignKey("ProductTypeDetail")]
        public int ProTypeID { get; set; }
        public virtual ProductTypeDetail ProductTypeDeTail { get; set; }
    }
}