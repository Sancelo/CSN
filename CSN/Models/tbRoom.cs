using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
#nullable disable

namespace CSN.Models
{
    [Table("tbRoom")]
    public class tbRoom
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string Password { get; set; }
        
    }
}