using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
#nullable disable

namespace CSN.Models
{
    [Table("tbMsg")]
    public partial class tbMsg
    {
        [Key]
        public int MsgId { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
        public int RoomId { get; set; }
        public bool IsRevoked { get; set; } = false; // Mặc định là không thu hồi
        public DateTime Date { get; set; } = DateTime.Now; // Thời gian tin nhắn }
    }
}
