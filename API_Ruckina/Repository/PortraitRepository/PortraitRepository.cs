using AppAmalt.Dto;
using AppAmalt.ModelsGraph;
using AppAmalt.ModelsDatabase;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class PortraitRepository : BasisRepository, IPortraitRepository
    {
        public PortraitRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphPortrait> GetPortraitAsync(int partyId)
        {
            var answer = await _context.Portraits
                .Include(u => u.City)
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphPortrait(
                sex: answer.Sex,
                occupation: answer.Occupation,
                lifeMain: answer.LifeMain,
                relation: answer.Relation,
                political: answer.Political,
                city: answer.City.Name,
                age: answer.Age);

        }
    }
}
