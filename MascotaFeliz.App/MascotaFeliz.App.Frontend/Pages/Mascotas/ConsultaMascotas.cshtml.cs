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
    public class ConsultaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota; 
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;

        public IEnumerable<Mascota> listaMascotas {get;set;}
        public IEnumerable<Mascota> listaMascotasFiltrados {get;set;}
        public IEnumerable<Dueno> listaDuenos {get;set;}
        public IEnumerable<Veterinario> listaVeterinarios {get;set;}


        [BindProperty(SupportsGet = true)]
        public string searchTerm {get;set;}
        [BindProperty(SupportsGet = true)]
        public string searchDueno {get;set;}
        [BindProperty(SupportsGet = true)]
        public string searchVeterinario {get;set;}

        public ConsultaMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnGet()
        {
            listaMascotas = _repoMascota.GetAllMascotas();
            listaMascotasFiltrados = _repoMascota.GetMascotasPorFiltro(searchTerm);
            listaMascotasFiltrados = _repoMascota.GetMascotasPorDueno(searchDueno, listaMascotasFiltrados);
            listaMascotasFiltrados = _repoMascota.GetMascotasPorVeterinario(searchVeterinario, listaMascotasFiltrados);

            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }
        
    }
}
