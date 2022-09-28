using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ContactenosModel : PageModel
    {
        private readonly ILogger<ContactenosModel> _logger;

        public ContactenosModel(ILogger<ContactenosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
