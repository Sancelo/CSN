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
        public int IdMsg { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
    }
}