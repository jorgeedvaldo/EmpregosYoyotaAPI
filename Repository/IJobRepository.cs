using EmpregosYoyotaAPI.Context;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpregosYoyotaAPI.Repository
{
    public interface IJobRepository
    {
        void Add(Job job);

        Task<ActionResult<List<Job>>> GetAll();

        Job Find(long id);

        void Remove(long id);

        void Update(Job job);
    }
}