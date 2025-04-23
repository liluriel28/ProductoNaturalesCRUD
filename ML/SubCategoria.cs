﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; }
        public ML.Categoria Categoria { get; set; }
        public List<Object> SubCategorias { get; set; }
    }
}
