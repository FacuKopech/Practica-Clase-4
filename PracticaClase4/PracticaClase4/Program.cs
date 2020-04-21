using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace PracticaClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Palabras words = new Palabras();
            int cantidad = words.CantidadPalabras();
            char caracter = '/';
            int cantidad2 = words.CantidadPalabras(caracter);
            string invertido = words.Invertir();

            Fechas dates = new Fechas();
            decimal minutos = dates.SegundosFechas();

            Enteros numeros = new Enteros();

            decimal promedio = numeros.PromedioEnteros();
            int resultado = numeros.OperacionesParesImpares();

            StringFecha fecha = new StringFecha();
            DateTime fechaa = fecha.ConvertirStringFecha();

            Array arr = new Array();
            string result = arr.ArrayAString(caracter);

            string email = "facukopech@gmail.com";
            bool vaidacion = email.ValidarMail();
            Console.WriteLine(vaidacion);
            
            
           
            Console.WriteLine(cantidad + invertido);
            Console.ReadLine();
        }
        
    }

    public sealed class Palabras
    {
        public string Texto { get; set; }
       
        public Palabras()
        {
            Texto = "Aca hay cuatro palabras.";
        }
    }

    public sealed class Fechas
    {
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
    } 

    public sealed class Enteros
    {
        public List<int> ListaEnteros { get; set; }
    } 

    public sealed class StringFecha
    {
        public string Fecha { get; set; }  
    }

    public sealed class Array
    {
        public string[] ArrayDeStrings { get; set; }
    } 

    public static class Extensiones
    {
        public static int CantidadPalabras(this Palabras texto)
        {
            int cantidad = 0;
            for (int i = 0; i < texto.Texto.Length; i++)
            {
                if (texto.Texto[i] == ' ' || texto.Texto[i] == '.')
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        public static int CantidadPalabras(this Palabras texto, char caracter)
        {

            //duda enunciado 
            return 0;

        }

        public static decimal SegundosFechas(this Fechas dates)
        {
            double segundos = (dates.Fecha2 - dates.Fecha1).TotalSeconds;
            decimal minutos = Convert.ToDecimal(segundos / 60);

            return minutos;
        }

        public static decimal PromedioEnteros(this Enteros numeros)
        {
            int suma = 0;

            foreach (var fila in numeros.ListaEnteros)
            {
                suma++;
            }

            int cantidad = numeros.ListaEnteros.Count();

            return suma / cantidad;

        }

        public static int OperacionesParesImpares(this Enteros numeros)
        {
            int sumaPares = 0;
            int restaImpares = 0;
            foreach (var fila in numeros.ListaEnteros)
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

        public static DateTime ConvertirStringFecha(this StringFecha fecha)
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

        public static string Invertir(this Palabras texto)
        {
            string invertido = null;
            foreach (char letra in texto.Texto)
            {
                invertido = letra + invertido;
            }

            return invertido;
        }

        public static string ArrayAString(this Array arreglo, char separador)
        {
            string cadena = null;
            for (int i = 0; i < arreglo.ArrayDeStrings.Length; i++)
            {
                cadena = cadena + arreglo.ArrayDeStrings[i] + separador;
            }

            return cadena;


        }

        public static bool ValidarMail(this string email)
        {
            
            Regex r = new Regex (@"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$");

            if (r.IsMatch(email))
            {
                return true;
            }

            return false;

        }
    }
}
