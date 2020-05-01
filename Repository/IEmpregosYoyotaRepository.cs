using System.Collections.Generic;
using System.Threading.Tasks;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpregosYoyotaAPI.Repository
{
    public interface IEmpregosYoyotaRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<ActionResult<List<Job>>> GetAllJobs();
        //Task<ActionResult<List<Job>>> GetJobById(int id);

        Task<ActionResult<List<Category>>> GetAllCategories();
        //Task<ActionResult<List<Job>>> GetCategoryById(int id);
    }
}