using AppAmalt.Dto;
using AppAmalt.ModelsGraph;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class LifeMainRepository : BasisRepository, ILifeMainRepository
    {
        public LifeMainRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphLifeMain> GetLifeMainAsync(int partyId)
        {
            var answer = await _context.LifeMains
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphLifeMain(
                family: answer.Family,
                careerMoney: answer.CareerMoney,
                famePower: answer.FamePower,
                entertainment: answer.Entertainment,
                science: answer.Science,
                selfDevelopment: answer.SelfDevelopment
            );

        }
    }
}
