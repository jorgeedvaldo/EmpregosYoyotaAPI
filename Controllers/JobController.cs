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
        private readonly IJobRepository _JobRepository;

        public JobController(IJobRepository repo)
        {
            _JobRepository = repo;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Job>>> GetAll()
        {
            return await _JobRepository.GetAll();
        }
    }
}