using Azure.Core;
using Competency.DOMAIN.Core.Interfaces;
using Competency.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competency.DOMAIN.Infrastructure.Repositories
{
    public class CompetencyRepository : ICompetencyRepository
    {
        private readonly Parcial20240221101034Context _context;

        public CompetencyRepository(Parcial20240221101034Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Competency.DOMAIN.Core.Entities.Competency>> GetCompetencies()
        {
            return await _context.Competency.ToListAsync();
        }


        public async Task Insert(Competency.DOMAIN.Core.Entities.Competency competency)
        {
            await _context.Competency.AddAsync(competency);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Competency.DOMAIN.Core.Entities.Competency competency)
        {
            _context.Competency.Update(competency);
            int countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var competency = await _context.Competency.FindAsync(id);
            if (competency != null)
            {
                return false;
            }
            _context.Competency.Remove(competency);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
