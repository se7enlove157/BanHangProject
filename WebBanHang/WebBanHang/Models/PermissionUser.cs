using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class PermissionUser
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key()]
        public int PerUserID { get; set; }
        public String PerUserName { get; set; }
        public String Mission { get; set; }
    }
}