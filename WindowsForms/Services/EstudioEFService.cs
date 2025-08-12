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
    public class EstudioEFService
    {
        public async Task<List<Estudio>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Estudios.ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var estudioABorrar = await cine.Estudios.FindAsync(id);
                estudioABorrar.Eliminado = true;
                cine.Estudios.Update(estudioABorrar);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar el estudio");
                }
            }
        }
        public async Task<bool> UpdateAsync(Estudio estudio)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Estudios.Update(estudio);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el estudio");
                }
            }
        }
        public async Task<bool> AddAsync(Estudio estudio)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Estudios.Add(estudio);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el estudio");
                }
            }
        }
    }
}
