using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Persona
    {
        private short _id;
        private string _nombre;
        private string _apellido;

        public short Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public override string ToString()
        {
            return this.Id + " " + this.Nombre + " " + this.Apellido;
        }

        public Persona(short pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }
    }
}
