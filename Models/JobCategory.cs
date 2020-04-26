using System;
namespace EmpregosYoyotaAPI.Models
{
    public class JobCategory
    {
        public int JobId { get; set; }
        public int CategoryId { get; set; }

        public Job Job { get; set; }
        public Category Category { get; set; }
    }
}