using System;
namespace EmpregosYoyotaAPI.Models
{
    public class Message
    {
        public int Id { get; set; }
        public String Author { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

    }
}