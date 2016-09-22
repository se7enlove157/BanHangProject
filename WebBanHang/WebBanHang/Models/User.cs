using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class User
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key()]
        public int UserID { get; set; }
        [Required]
        public String UserName { get; set; }
        public String UserPass { get; set; }
        public DateTime BirthDay { get; set; }
        public String Name { get; set; }
        [Required]
        public String Email { get; set; }
        [ForeignKey("PermissionUser")]
        public int PerUserID { get; set; }
        public virtual PermissionUser PermissionUser { get; set; }
    }
}