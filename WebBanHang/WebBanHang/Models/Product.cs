using System;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Product
    {
        [Key]
        public int ProID { get; set; }
        public String  ProName { get; set; }


        public int CateID { get; set; }
        public virtual Category Categories { get; set; }

    }
}