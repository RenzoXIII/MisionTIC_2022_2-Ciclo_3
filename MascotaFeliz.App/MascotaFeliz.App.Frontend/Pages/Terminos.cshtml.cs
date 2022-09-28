using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class TerminosModel : PageModel
    {
        private readonly ILogger<TerminosModel> _logger;

        public TerminosModel(ILogger<TerminosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
