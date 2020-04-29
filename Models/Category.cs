using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpregosYoyotaAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public List<JobCategory> JobCategories { get; set; }
    }
}