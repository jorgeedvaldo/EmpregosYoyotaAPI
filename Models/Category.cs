using System;
using System.Collections.Generic;

namespace EmpregosYoyotaAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<JobCategory> JobCategories { get; set; }
    }
}