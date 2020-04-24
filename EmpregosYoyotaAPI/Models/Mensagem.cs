using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpregosYoyotaAPI.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Msg { get; set; }
    }
}