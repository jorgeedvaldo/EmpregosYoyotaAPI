using EmpregosYoyotaAPI.Repository;
using EmpregosYoyotaAPI.Context;
using EmpregosYoyotaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Job>> GetById(int id)
        {
            try
            {
                var job = await _EmpregosYoyotaRepository.GetJobById(id);
                return job;
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}