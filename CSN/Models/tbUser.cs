using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
#nullable disable

namespace CSN.Models
{
    [Table("tbUser")]
    public class tbUser
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}






