using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddDueno();
            //AddVeterinario();
            //AddMascota();

            //BuscarDueno(1);
            //BuscarVeterinario(2);
            //BuscarMascota(1);

            ListarDuenos();
            //ListarVeterinarios();
            //ListarMascotas();
        }

        //----Add Methods----

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Cedula = "1414",
                Nombres = "Jose",
                Apellidos = "Perez",
                Direccion = "Av 26 - 35",
                Telefono = "318578475",
                Correo = "joseperez@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Cedula = "1313",
                Nombres = "Pepe",
                Apellidos = "González Florez",
                Direccion = "Av 23 # 57 - 32",
                Telefono = "5555555555",
                TarjetaProfesional = "2190526"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Tommy",
                Color = "Sepia",
                Especie = "Perro",
                Raza = "Cocker Spaniel",
            };
            _repoMascota.AddMascota(mascota);
        }

        //----Search Methods----

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Cedula + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Cedula + " " + veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
        }

        //----List Multiple Methods----

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario d in veterinarios)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre);
            }
        }
    }
}
