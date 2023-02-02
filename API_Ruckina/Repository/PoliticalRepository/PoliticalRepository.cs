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
    public class PoliticalRepository : BasisRepository, IPoliticalRepository
    {
        public PoliticalRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphPolitical> GetPoliticalAsync(int partyId)
        {
            var answer = await _context.Politicals
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphPolitical(
                communists: answer.Communists,
                socialists: answer.Socialists,
                moderate: answer.Moderate,
                liberals: answer.Liberals,
                conservatives: answer.Conservatives,
                indifferents: answer.Indifferents);

        }
    }
}
