﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.ViewModels
{
    public class RegistroViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
	    public string Email { get; set; } 
	    public string Senha { get; set; }
        public int IdTipoUsuario { get; set; }
    }
}
