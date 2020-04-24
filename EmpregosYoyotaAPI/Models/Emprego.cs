using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpregosYoyotaAPI.Models
{
    public class Emprego
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Empresa { get; set; }
        public String Provincia { get; set; }
        public DateTime DataPublicado { get; set; }
        public DateTime DataExpira { get; set; }
        public String Descricao { get; set; }
        public String Email { get; set; }
        public String Foto { get; set; }

        public List<EmpregoCategoria> EmpregoCategorias { get; set; }
    }
}