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
    public class ActorEFService
    {
        public async Task<List<Actor>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Actores.ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var actorABorrar = await cine.Actores.FindAsync(id);
                actorABorrar.Eliminado = true;
                cine.Actores.Update(actorABorrar);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar el actor");
                }
            }
        }
        public async Task<bool> UpdateAsync(Actor actor
            )
        {
            using (CineContext cine = new CineContext())
            {
                cine.Actores.Update(actor);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el actor");
                }
            }
        }
        public async Task<bool> AddAsync(Actor actor)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Actores.Add(actor);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el actor");
                }
            }
        }
    }
}
