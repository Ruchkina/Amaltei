//using AppAmalt.Dto;
using AppAmalt.ModelsGraph;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class AgeRepository : BasisRepository, IAgeRepository
    {
        public AgeRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphAge> GetAgeAsync(int partyId)
        {
            var answer = await _context.Age
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphAge(
                less20Age: answer.Less20Age,
                between20_30Age: answer.Between20_30Age,
                between30_40Age: answer.Between30_40Age,
                between40_60Age: answer.Between40_60Age,
                over60: answer.Over60
            );

        }
    }
}
