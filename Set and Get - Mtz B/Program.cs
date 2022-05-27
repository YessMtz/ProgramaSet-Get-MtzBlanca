using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_and_Get___Mtz_B
{
    class Program
    {
        //CREACION DE LA CLASE PELICULA
        class Pelicula
        {
            //CAMPOS DE LA CLASE CON UN CAMBIO PRIVADO
            public string Titulo, Director;
            private string rating = " ";
            
            //CONSTRUCTOR DE LA CLASE 
            public Pelicula(string aTitulo, string aDirector, string aRating)
            {
                this.Titulo = aTitulo;
                this.Director = aDirector;
                this.rating = aRating;
            }

            //METODO SET AND GET
            public string aRating
            {
                get { return rating;  }

                set
                {
                    if(value == "G" || value== "PG")
                    {
                        rating = value;
                    }
                    else
                    {
                        rating = "NR";
                    }

                }
            }

            //DESTRUCTOR DE LA CLASE
            ~Pelicula()
            {
                Console.WriteLine("Memoria de la clase liberada");
            }

        }

        static void Main(string[] args)
        {
            //CREACION DE OBJETOS DE LA CLASE PELICULA
            Pelicula nuevaPelicula = new Pelicula("La vida es bella", "Roberto", "PG");
            Pelicula nuevaPelicula2 = new Pelicula("Justice Leaague Zack Snyders", "Zack Snyder", "Warner");

            Console.WriteLine(nuevaPelicula2.aRating);
            Console.ReadKey();
        }
    }
}
