using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
#nullable disable

namespace CSN.Models
{
    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int TextId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
    }
}


