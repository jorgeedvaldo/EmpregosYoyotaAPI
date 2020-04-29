using System;
using System.ComponentModel.DataAnnotations;

namespace EmpregosYoyotaAPI.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public String Author { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

    }
}