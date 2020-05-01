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
    [Route("api/categories")]

    public class CategoryController : ControllerBase
    {
        private readonly IEmpregosYoyotaRepository _EmpregosYoyotaRepository;

        public CategoryController(IEmpregosYoyotaRepository repo)
        {
            _EmpregosYoyotaRepository = repo;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            var categories = await _EmpregosYoyotaRepository.GetAllCategories();
            return categories;
        }
    }
}