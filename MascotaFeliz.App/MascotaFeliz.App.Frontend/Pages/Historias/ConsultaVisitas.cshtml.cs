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
    public class ConsultaVisitasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota; 
        //private readonly IRepositorioDueno _repoDueno;
        public readonly IRepositorioVeterinario _repoVeterinario;

        [BindProperty(SupportsGet = true)]
        public string mascotaId {get;set;}
        

        public Mascota mascota {get;set;}
        public IEnumerable<VisitaPyP> listaVisitas {get;set;}
        public Veterinario veterinarioEncontrado {get;set;}
    

        public ConsultaVisitasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            //this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }


        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);
                listaVisitas = mascota.Historia.VisitasPyP;

            }
            else
            {
                return RedirectToPage("./NotFound");
            }
            if (mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
