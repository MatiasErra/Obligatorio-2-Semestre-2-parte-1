using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Venta
    {
        private short _id;
        private DateTime _FechaVen;
        private Libro _libro;
        private Autor _autor;
        private Lector _lector;

        public short Id { get => _id; set => _id = value; }
        public DateTime FechaVen { get => _FechaVen; set => _FechaVen = value; }
        internal Libro Libro { get => _libro; set => _libro = value; }
        internal Autor Autor { get => _autor; set => _autor = value; }
        internal Lector Lector { get => _lector; set => _lector = value; }


        public override string ToString()
        {
            return this.Id + " " + this.FechaVen.ToShortDateString() + " " + this.Libro.Titulo + " " + this.Libro.Autor+ " " + this.Libro.Precio + " " + this.Lector.Nombre;
         }

        public Venta(short pId, DateTime pFechaVen, Libro pLibro, Autor pAutor, Lector pLector)
        {
            this.Id = pId;
            this.FechaVen = pFechaVen;
            this.Libro = pLibro;
            this.Autor = pAutor;
            this.Lector = pLector;


        }

        
    }
}
