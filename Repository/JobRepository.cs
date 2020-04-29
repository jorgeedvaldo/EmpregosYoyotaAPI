using EmpregosYoyotaAPI.Context;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpregosYoyotaAPI.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly DataContext _Context;

        public JobRepository(DataContext _Ctx)
        {
            this._Context = _Ctx;
        }

        public void Add(Job job)
        {

        }

        public async Task<ActionResult<List<Job>>> GetAll()
        {
            var categories = await _Context.Jobs.ToListAsync();
            return categories;
        }

        public Job Find(long id)
        {
            return new Job(); //_Context.Jobs.FirstOnDefault(j => j.Id == id);
        }

        public void Remove(long id)
        {

        }

        public void Update(Job job)
        {

        }
    }
}