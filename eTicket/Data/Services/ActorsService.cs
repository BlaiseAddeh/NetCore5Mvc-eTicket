using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            this._context = context;
        }






        /*

        public async Task AddAsync(Actor actor)
        {
            await this._context.Actors.AddAsync(actor);
            await this._context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await this._context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }


        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            this._context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }

        */


    }
}
