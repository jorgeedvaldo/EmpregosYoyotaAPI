using EmpregosYoyotaAPI.Repository;
using EmpregosYoyotaAPI.Context;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpregosYoyotaAPI.Controllers
{
    [ApiController]
    [Route("api/jobs")]

    public class JobController : ControllerBase
    {
        private readonly IEmpregosYoyotaRepository _EmpregosYoyotaRepository;

        public JobController(IEmpregosYoyotaRepository repo)
        {
            _EmpregosYoyotaRepository = repo;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Job>>> GetAll()
        {
            var jobs = await _EmpregosYoyotaRepository.GetAllJobs();
            return jobs;
        }
    }
}