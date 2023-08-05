using AutoMapper;
using CalenderManagement.Data;
using CalenderManagement.DTOs;
using CalenderManagement.Interface;
using CalenderManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalenderManagement.ImplementInterface
{
    public class AdminFormRepository : IAdminForm
    {

        private readonly DataContext _context;

        public AdminFormRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(AdminForm entity)
        {
            _context.Set<AdminForm>().Add(entity);
        }


        public async Task<IEnumerable<AdminForm>> GetAllevent()
        {
            return await _context.Set<AdminForm>().ToListAsync();

        }

        public async Task<AdminForm> GetById(int id)
        {
            return await _context.admin.FirstOrDefaultAsync(AdminForm => AdminForm.id == id);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        //====================================================================================

    }
}
