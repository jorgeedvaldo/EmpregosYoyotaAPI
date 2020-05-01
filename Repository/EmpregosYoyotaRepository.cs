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



        public async Task<ActionResult<List<Job>>> GetAllJobs()
        {
            var query = await _Context.Jobs
                .Include(j => j.JobCategories)
                    .ThenInclude(jc => jc.Category)
                .ToListAsync();
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
    }
}