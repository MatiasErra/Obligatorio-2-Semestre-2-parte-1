using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Lector:Persona
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public Lector(short pId, string pNombre, string pApellido)
            :base(pId, pNombre, pApellido)
        { }
    }
}
