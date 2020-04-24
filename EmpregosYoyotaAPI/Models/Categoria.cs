﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpregosYoyotaAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<EmpregoCategoria> EmpregoCategorias { get; set; }
    }
}