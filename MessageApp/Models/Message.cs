using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MessageApp.Models
{
    public class Message
    {
        public int ID { get; set; }

        [StringLength(256, ErrorMessage = "Invalid length", MinimumLength = 3)]
        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime MessageDate { get; set; }

        [StringLength(24)]
        [Required]
        public string Genre { get; set; }

        [Range(1, 5)]
        public int Stars { get; set; }

    }

    public class MessageDBContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}