using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Logica
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public decimal Saldo { get; set; }

        public static Cliente operator -( Cliente cli1,  Cliente cli2)
        {
            if (cli1.CUIT==cli2.CUIT)
            {
                decimal resta = cli1.Saldo - cli2.Saldo;
                cli1.Saldo = resta;
                
            } 
            else
            {
                if (cli1.Saldo < cli2.Saldo)
                {
                    cli1.Saldo = cli1.Saldo;
                }
                else
                {
                    cli1.Saldo = cli2.Saldo;
                    
                }
            }

            return cli1;
        }
    }
}
