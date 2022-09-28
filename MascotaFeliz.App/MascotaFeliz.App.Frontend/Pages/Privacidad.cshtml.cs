using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class PrivacidadModel : PageModel
    {
        private readonly ILogger<PrivacidadModel> _logger;

        public PrivacidadModel(ILogger<PrivacidadModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
