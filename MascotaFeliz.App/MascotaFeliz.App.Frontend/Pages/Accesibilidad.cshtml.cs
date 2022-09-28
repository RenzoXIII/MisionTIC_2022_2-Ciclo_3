using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class AccesibilidadModel : PageModel
    {
        private readonly ILogger<AccesibilidadModel> _logger;

        public AccesibilidadModel(ILogger<AccesibilidadModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
