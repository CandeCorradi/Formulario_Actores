using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.DataContext;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class PeliculaEFService
    {
        string url = "https://practprof2023-2855.restdb.io/rest/movies?apikey=5ef3666c6a76415a50ddab26a474d3a68c6b4";

        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Peliculas.Include(p=>p.Pais).ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var peliculaABorrar = await cine.Peliculas.FindAsync(id);
                peliculaABorrar.Eliminado = true;
                cine.Peliculas.Update(peliculaABorrar);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar la pelicula");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Update(pelicula);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar la pelicula");
                }
            }
        }
        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Add(pelicula);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la pelicula");
                }
            }
        }
    }
}
