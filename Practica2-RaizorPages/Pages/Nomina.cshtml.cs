using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica2_RaizorPages.Pages
{
    public class NominaModel : PageModel
        
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public double Descuento { get; set; }

        public List<string> Nombres;
        public List<string> Apellidos;
        public List<string> Cargos;
        public List<double> Salarios;
        


        public NominaModel()
        {
            Nombres = new List<string>()
            {
                "Eduardo", "Odalis", "Cristina", "Angela", "Samuel"
            };

            Apellidos = new List<string>()
            {
                "Acosta", "Paulino", "Zapata", "Rodriguez", "Ruiz"
            };
            Cargos = new List<string>()
            {
                "Programador", "Arquitecta", "Vendedora", "Ama de casa", "Profesor"
            };

            Salarios = new List<double>()
            {
                13482, 30000, 25000, 18000, 20000
            };
            

        }
        public double SFS(double Salario)
        {
            double dec;
            dec = Salario * 0.0304;
            return dec;
         
        }
        public double AFP(double Salario)
        {
            double dec;           
            dec = Salario * 0.0287;
            return dec;

        }

        public double IRS(double Salario)
        {
            double dec, dec1, dec2, dec3 ;
            dec = 0;
            dec1 = Salario*0.15;
            dec2= Salario * 0.20;
            dec3= Salario * 0.25;

            if (Salario< 416220)
            {
                Console.WriteLine("Exento");
            }
            if(Salario >= 416220 ^ Salario< 624329)
            {
                dec = dec1;
                
            }
            if(Salario > 624329 ^ Salario < 867123)
            {
                dec = dec2;
                

            }
            if (Salario >= 867123)
            {
                dec = dec3;
                

            }
            return dec;
        }
        public double Total_descuento(double sfs, double afp, double irs)
        {
            double monto_total;
            monto_total = sfs + afp + irs;
            return monto_total;
        }
        public double SalarioNeto(double Salario, double total_descuento)
        {
            double neto;
            neto = Salario - total_descuento;
            return neto;
        }


        



        public void OnGet()
        {
        }
    }
}
