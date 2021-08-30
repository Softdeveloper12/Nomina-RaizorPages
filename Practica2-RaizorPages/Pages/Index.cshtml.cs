using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2_RaizorPages.Pages
{
    public class Nomina : PageModel
    {
        private readonly ILogger<Nomina> _logger;
        
        public Nomina(ILogger<Nomina> logger)
        {
            _logger = logger;
        }
        

        public void OnGet()
        {
            

        }
    }
}
