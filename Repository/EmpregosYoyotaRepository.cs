using EmpregosYoyotaAPI.Context;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace EmpregosYoyotaAPI.Repository
{
    public class EmpregosYoyotaRepository : IEmpregosYoyotaRepository
    {
        private readonly DataContext _Context;

        public EmpregosYoyotaRepository(DataContext _Ctx)
        {
            this._Context = _Ctx;
        }

        public void Add<T>(T entity) where T : class
        {
            _Context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _Context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _Context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _Context.SaveChangesAsync()) > 0;
        }


        public async Task<ActionResult<List<Job>>> GetAllJobs()
        {
            var query = await _Context.Jobs
                .Include(j => j.JobCategories)
                    .ThenInclude(jc => jc.Category)
                .ToListAsync();
            return query;
        }

        public async Task<ActionResult<Job>> GetJobById(int id)
        {
            var query = await _Context.Jobs
                .Include(j => j.JobCategories)
                    .ThenInclude(jc => jc.Category)
                .FirstOrDefaultAsync(j => j.Id == id);
            return query;
        }

        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var query = await _Context.Categories
                .Include(c => c.JobCategories)
                    .ThenInclude(jc => jc.Job)
                .ToListAsync();
            return query;
        }

        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var query = await _Context.Categories
                .Include(c => c.JobCategories)
                    .ThenInclude(jc => jc.Job)
                .FirstOrDefaultAsync(j => j.Id == id);
            return query;
        }

    }
}