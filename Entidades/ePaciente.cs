using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePaciente
    {
        public string DNI { get; set; }

        public string NombreCompleto { get; set; }

        public string Sexo { get; set; }

        public string Distrito { get; set; }

        public int FechaNacimiento { get; set; }


        public int FechaRegistro { get; set; }

        public int Edad()
        {
            int anios = AnioCumplido(FechaNacimiento);
            return anios;
        }

        public int Registro() {
            int anioregistro = AnioCumplido(FechaRegistro);
            return anioregistro;
        }

        public int AnioCumplido(int fecha)
        {
            DateTime d;
            d = DateTime.Today; 
            int año = fecha % 10000;//27112002
            //2002
            int aux = fecha - año;//27110000
            aux = aux / 1000;//2711
            int mes = aux % 100; //11
            int dia = aux / 100; //27
            int cantanios = (d.Year - 1) - año;
            //18
            //11-11=0
            //27-27=0

            if(d.Month - mes >= 0 && d.Day - dia >=0)
            {
                cantanios++;
            }
            return cantanios;

            //19

        }






    }
}
