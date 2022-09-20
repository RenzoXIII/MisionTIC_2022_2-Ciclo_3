using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;


namespace MascotaFeliz.App.Frontend.Pages
{
    public class ConsultaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        public IEnumerable<Dueno> listaDuenos {get;set;}
        public IEnumerable<Dueno> listaDuenosFiltrados {get;set;}


        [BindProperty(SupportsGet = true)]
        public string searchTerm {get;set;}

        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
            listaDuenosFiltrados = _repoDueno.GetDuenosPorFiltro(searchTerm);
        }
        
    }
}
