using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Libro
    {
        private short _id;
        private string _titulo;
        private string _genero;
        private DateTime _ano;
        private Autor _autor;
        private double _precio;
        private string _comentario;
        private int _cantVend;

        public short Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime Ano { get => _ano; set => _ano = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
        internal Autor Autor { get => _autor; set => _autor = value; }
        public int CantVend { get => _cantVend; set => _cantVend = value; }

        public override string ToString()
        {
            return this.Id +" " + this.Titulo + " " +  this.Autor.Nombre + " "+ this.Genero + " " + this.Ano.Year + " $" + this.Precio + " " + this.CantVend;
        }

        public void IngresoCantVend(int pCantVend)
        {
            this.CantVend = pCantVend;  
        }


        public Libro(short pId, string pTitulo, string pGenero, DateTime pAno, Autor pAutor, double pPrecio, string pComentario)
        {
            this.Id = pId;
            this.Titulo = pTitulo;
            this.Genero = pGenero;
            this.Ano = pAno;
            this.Autor = pAutor;
            this.Precio = pPrecio;
            this.Comentario = pComentario;

        }
    }
}
