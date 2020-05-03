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
    [Route("api/messages")]    

    public class MessageController : ControllerBase
    {
        private readonly IEmpregosYoyotaRepository _EmpregosYoyotaRepository;

        public MessageController(IEmpregosYoyotaRepository repo)
        {
            _EmpregosYoyotaRepository = repo;
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(Message message)
        {
            try
            {
                _EmpregosYoyotaRepository.Add(message);
               
                if(await _EmpregosYoyotaRepository.SaveChangesAsync())
                {
                    return Ok("A sua mensagem foi enviada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest("Erro ao enviar, por  favor tente mais tarde.");
        }
    }
}