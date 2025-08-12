﻿using Microsoft.EntityFrameworkCore;
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
    public class PaisEFService
    {
        public async Task<List<Pais>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Paises.ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var paisABorrar = await cine.Paises.FindAsync(id);
                paisABorrar.Eliminado = true;
                cine.Paises.Update(paisABorrar);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar el pais");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pais pais)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Paises.Update(pais);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el pais");
                }
            }
        }
        public async Task<bool> AddAsync(Pais pais)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Paises.Add(pais);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el pais");
                }
            }
        }
    }
}
