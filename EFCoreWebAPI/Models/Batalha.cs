﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebAPI.Models {
    public class Batalha 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
