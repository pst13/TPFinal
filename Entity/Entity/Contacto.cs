﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public partial class Contacto
    {
        public string concatenaNombre()
        { return this.Nombre+"    "+this.Direccion;
        }
    }
}
