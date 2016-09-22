using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class ProductTypeDetail
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key()]
        public int ProTypeID { get; set; }
        public String TypeName { get; set; }

    }
}