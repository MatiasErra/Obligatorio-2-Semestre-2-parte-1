using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Autor:Persona
    {
        private DateTime _fechaDeN;
        private string _fechaDeF;
        private string _nacionalidad;
        private int _librosVend;

        public DateTime FechaDeN { get => _fechaDeN; set => _fechaDeN = value; }
        public string FechaDeF { get => _fechaDeF; set => _fechaDeF = value; }
        public string Nacionalidad { get => _nacionalidad; set => _nacionalidad = value; }
        public int LibrosVend { get => _librosVend; set => _librosVend = value; }

        public override string ToString()
        {
            return base.ToString() +" "   + this.Nacionalidad+ " " + this.FechaDeN.Year +  " " +this.FechaDeF + "  " + this.LibrosVend;


        }
        public void IngresoLibrosVend(int pLibrosVend)
        {
            this.LibrosVend =  pLibrosVend;
        
        }

        public Autor(short pId, string pNombre, string pApellido, string pNacionalidad, DateTime pFechaDeN, string pFechaDeF)
            : base(pId, pNombre, pApellido)
        {
            this.FechaDeN = pFechaDeN;
            this.FechaDeF = pFechaDeF;
            this.Nacionalidad = pNacionalidad;
        }
    }
}
