using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio1octubre.Dominio
{
    class Municipalidad
    {
        private static List<Venta> _listaVentas = new List<Venta>();
        private static List<Libro> _listaLibros = new List<Libro>();
        private static List<Lector> _listaLectores = new List<Lector>();
        private static List<Autor> _listaAutores = new List<Autor>();


        public List<Venta> ListaVentas()
        {
            return _listaVentas;
        }
        public List<Libro> ListaLibros()
        {
            return _listaLibros;
        }
        public List<Lector> ListaLectores()
        {
            return _listaLectores;
        }
        public List<Autor> ListaAutores()
        {
            return _listaAutores;
        }

        #region ABM Ventas
        public Venta BuscarVenta(short pId)
        {
            foreach (Venta unVenta in _listaVentas)
            {
                if (unVenta.Id == pId)
                    return unVenta;
            }
            return null;

        }



        public bool Altavent(Venta pVenta)
        {
            Venta unVenta = BuscarVenta(pVenta.Id);

            if (unVenta == null)
            {
                _listaVentas.Add(pVenta);
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Bajavent(short pId)
        {
            Venta unVenta = this.BuscarVenta(pId);
            if (unVenta != null)
            {
                _listaVentas.Remove(unVenta);

                return true;
            }
            else
                return false;
        }
        #endregion

        #region ABM Libro 
        public Libro BuscarLibro(short pId)
        {
            foreach (Libro unLibro in _listaLibros)
            {
                if (unLibro.Id == pId)
                {
                    return unLibro;

                }
            }
            return null;

        }

        public bool AltaLibro(Libro pLibro)
        {
            Libro unlibro = BuscarLibro(pLibro.Id);
            if (unlibro == null)
            {
                _listaLibros.Add(pLibro);
                
                return true;
            }
            else
                return false;


        }
        public bool BajaLibro(short pId)
        {
            Libro unlibro = BuscarLibro(pId);
            if (unlibro != null)
            {
                _listaLibros.Remove(unlibro);
                return true;
            }
            else
                return false;
        }

        public bool ModificarLibro(short pId, string pTitulo, string pGenero, DateTime pAno, Autor pAutor, double pPrecio, string pComentario)
        {
            Libro unlibro = BuscarLibro(pId);
            {
                if (unlibro != null)
                {
                    unlibro.Id = pId;
                    unlibro.Titulo = pTitulo;
                    unlibro.Genero = pGenero;
                    unlibro.Ano = pAno;
                    unlibro.Autor = pAutor;
                    unlibro.Precio = pPrecio;
                    unlibro.Comentario = pComentario;
                    return true;

                }
                else
                    return false;

            }


        }
        public List<Libro> ListaOrdenadaLibro()
        {
            List<Libro> LibrosOrdenados = new List<Libro>(_listaLibros);
            Libro auxLibro;
            for (int i = 0; i < LibrosOrdenados.Count; i++)
            {
                for (int j = 0; j < LibrosOrdenados.Count - 1; j++)
                {
                    if (LibrosOrdenados[j].Titulo.ToUpper().CompareTo(LibrosOrdenados[j + 1].Titulo.ToUpper()) > 0)
                    {
                        auxLibro = LibrosOrdenados[j];
                        LibrosOrdenados[j] = LibrosOrdenados[j + 1];
                        LibrosOrdenados[j + 1] = auxLibro;
                    }
                }
            }
            return LibrosOrdenados;
        }

        #endregion

        #region ABM Lectores

        public Lector BuscarLector(short pId)
        {
            foreach (Lector unLector in _listaLectores)
            {
                if (unLector.Id == pId)
                {
                    return unLector;

                }
            }
            return null;

        }
        public bool AltaLector(Lector pLector)
        {
            Lector unLector = BuscarLector(pLector.Id);
            if (unLector == null)
            {
                _listaLectores.Add(pLector);
                return true;
            }
            else
                return false;


        }
        public bool BajaLector(short pId)
        {
            Lector unLector = BuscarLector(pId);
            if (unLector != null)
            {
                _listaLectores.Remove(unLector);
                return true;
            }
            else
                return false;
        }

        public bool ModificarLector(short pId, string pNombre, string pApellido)
        {
            Lector unLector = BuscarLector(pId);
            {
                if (unLector != null)
                {
                    unLector.Id = pId;
                    unLector.Nombre = pNombre;
                    unLector.Apellido = pApellido;

                    return true;

                }
                else
                    return false;

            }


        }


        #endregion

        #region ABM Autor
        public Autor BuscarAutor(short pId)
        {
            foreach (Autor unAutor in _listaAutores)
            {
                if (unAutor.Id == pId)
                    return unAutor;

            }
            return null;

        }
        public bool AltaAutor(Autor pAutor)
        {
            Autor unAutor = BuscarAutor(pAutor.Id);
            if (unAutor == null)
            {
                _listaAutores.Add(pAutor);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool BajaAutor(short pId)
        {
            Autor unAutor = BuscarAutor(pId);
            if (unAutor != null)
            {
                _listaAutores.Remove(unAutor);
                return true;
            }
            else
                return false;
        }

        public bool ModificarAutor(short pId, string pNombre, string pApellido, string pNacionalidad, DateTime pFechaDeN, string pFechaDeF)
        {
            Autor unAutor = BuscarAutor(pId);
            {
                if (unAutor != null)
                {
                    unAutor.Id = pId;
                    unAutor.Nombre = pNombre;
                    unAutor.Apellido = pApellido;
                    unAutor.FechaDeN = pFechaDeN;
                    unAutor.FechaDeF = pFechaDeF;
                    unAutor.Nacionalidad = pNacionalidad;

                    return true;

                }
                else
                    return false;

            }

            #endregion

        }


            #region Consultas
              public double Recuadacion()
            {
            double resultado = 0;
                foreach (Venta unVenta in _listaVentas)
                {
                    
                     resultado  = resultado + unVenta.Libro.Precio;
                       

                }
                return resultado;
            }


        public bool IngresoCant  (short pId)
        {
            //en estadisticas falta poner el metodo en recargar para que cuando se ingrese la primera vez no de 0 
            Autor unAutor = this.BuscarAutor(pId);
            if(unAutor != null)
            {
                foreach(Venta venta in _listaVentas)
                {
                    if (venta.Autor.Id == unAutor.Id)
                    {
                        unAutor.LibrosVend++;
                    }
                }
            
                return true;
            }
            else
            {
                return false;
            }
              
            

        }
        public bool IngresoCunt(short pId, int pLibrosVend)
        {
            Autor unAutor = this.BuscarAutor(pId);
            if (unAutor != null)
            {
                pLibrosVend = pLibrosVend - 1;
                unAutor.IngresoLibrosVend(pLibrosVend);
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool IngresoLibCant(short pId, int pCantVend)
        {
            Libro unlibro = this.BuscarLibro(pId);
            if (unlibro != null)
            {
                pCantVend = pCantVend + 1;
                unlibro.IngresoCantVend(pCantVend);
                return true;

            }
            else
                return false;
        }
        public bool IngresoLibCunt(short pId, int pCantVend)
        {
            Libro unlibro = this.BuscarLibro(pId);
            if (unlibro != null)
            {
                pCantVend = pCantVend - 1;
                unlibro.IngresoCantVend(pCantVend);
                return true;

            }
            else
                return false;
        }


        public List<Autor> AutorConMasLibrosVend()
        {
            int mayor = 0;
            List<Autor> AutorVentas = new List<Autor>(_listaAutores);
            foreach(Autor unAutor in _listaAutores)
            {
                if (unAutor.LibrosVend > 0 && unAutor.LibrosVend > mayor)
                {
                    AutorVentas.Clear();
                    AutorVentas.Add(unAutor);
                    mayor = unAutor.LibrosVend;
                }
                else if(unAutor.LibrosVend> 0 && unAutor.LibrosVend ==mayor)
                {
                    AutorVentas.Add(unAutor);
                    mayor = unAutor.LibrosVend;

                }
            }
            return AutorVentas;
            
        }

        public List<Libro>LibroConMasVent()
        {
            int mayor = 0;
         List<Libro> LibroVentas = new List<Libro>(_listaLibros);
            foreach (Libro unLibro in _listaLibros)
            {
                if (unLibro.CantVend > 0 && unLibro.CantVend > mayor)
                {
                    LibroVentas.Clear();
                    LibroVentas.Add(unLibro);
                    mayor = unLibro.CantVend;
                }
                else if (unLibro.CantVend > 0 && unLibro.CantVend == mayor)
                {
                  LibroVentas.Add(unLibro);
                    mayor = unLibro.CantVend;

                }
            }
            return LibroVentas;

        }
        public int comp() {
            int resultado = 0;
            List<Libro> unosLibros = LibroConMasVent();
            foreach(Libro unlibro in unosLibros)
            {
               resultado = 100/unosLibros.Count;
            }
            return resultado;
        }
        public List<Venta> LectorDadoNom(string pNombre)
        {
          
            Lector unLecNom = this.BuscarLectorNom(pNombre);
            List<Venta> LectVen = new List<Venta>();
            foreach (Venta unaVenta in _listaVentas)
            {
                if (unaVenta.Lector.Nombre ==unLecNom.Nombre)
                {
                    LectVen.Add(unaVenta);

                }

            }
            return LectVen;


        }
     
               public Lector BuscarLectorNom(string pNombre)
        {
            foreach (Lector lector in _listaLectores)
            {
                if (lector.Nombre ==pNombre)
                {
                    return lector;
                }
            }
            return null;

        }

       

        #endregion


    }
}