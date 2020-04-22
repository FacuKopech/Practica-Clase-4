using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Logica;

namespace Logica
{
    public static class Extensiones
    {

        public static int CantidadPalabras(this string texto)
        {
            //return texto.split(' ').Length; //Con esto es suficiente

            int cantidad = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ' || texto[i] == '.')
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        public static int CantidadPalabras(this string texto, char caracter)
        {
            //return texto.split(caracter).Length; //Con esto es suficiente
            int cantidad = 0;
            for (int i = 0; i < texto.Length; i++) 
            {
                if (texto[i] == ' ')
                {
                    texto[i] = caracter;
                    cantidad++;
                }
            }

            return cantidad;

        }

        public static decimal SegundosFechas(this DateTime dates, DateTime fecha1, DateTime fecha2)
        {
            double segundos = (fecha2 - fecha1).TotalSeconds;
            decimal minutos = Convert.ToDecimal(segundos / 60);

            return minutos;
        }

        public static decimal PromedioEnteros(this List<int> numeros)
        {
            int suma = 0;
            //return numeros.Average(); //Con esto es suficiente

            foreach (var fila in numeros)
            {
                suma++;
            }

            int cantidad = numeros.Count();

            return suma / cantidad;

        }

        public static int OperacionesParesImpares(this List<int> numeros)
        {
            int sumaPares = 0;
            int restaImpares = 0;
            foreach (var fila in numeros)
            {
                if (fila % 2 == 0)
                {
                    sumaPares = sumaPares + fila;
                }
                else
                {
                    restaImpares = restaImpares - fila;
                }
            }

            return sumaPares * restaImpares;
        }

        public static DateTime ConvertirStringFecha(this string fecha)
        {
            DateTime fechaa;
            try
            {
                fechaa = Convert.ToDateTime(fecha);
            }
            catch (Exception e)
            {
                fechaa = DateTime.MinValue;

            }
            return fechaa;
        }

        public static string Invertir(this string texto)
        {
            //return texto.Reverse().ToString(); //Con esto es suficiente
            string invertido = null;
            foreach (char letra in texto)
            {
                invertido = letra + invertido;
            }

            return invertido;
        }

        public static string ArrayAString(this string[] arreglo, char separador)
        {
            //return string.Join(separador, arreglo); //Con esto es suficiente
            string cadena = null;
            for (int i = 0; i < arreglo.Length; i++)
            {
                cadena = cadena + arreglo[i] + separador;
            }

            return cadena;


        }

        public static bool ValidarMail(this string email)
        {
            Regex r = new Regex(@"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$");

            //return r.IsMatch(email); //Con esto es suficiente

            if (r.IsMatch(email))
            {
                return true;
            }

            return false;

        }

        /// <summary>
        /// NO se entiende que quisiste hacer aca.
        /// </summary>
        /// <param name="numeros"></param>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static int RestaEnteros(this int numeros, int numero1, int numero2)
        {
            return numero1 - numero2;
        }

       

        
    }
}
