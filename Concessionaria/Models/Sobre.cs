﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concessionaria.Models
{
    public class Sobre
    {
        [Key]
        public int ID { get; set; }
        public string Conteudo { get; set; }
    }
}