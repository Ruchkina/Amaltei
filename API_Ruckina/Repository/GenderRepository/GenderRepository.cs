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
    public class GenderRepository : BasisRepository, IGenderRepository
    {
        public GenderRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphGender> GetGenderAsync(int partyId)
        {
            var answer = await _context.Genders
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphGender(
                man: answer.MenFollower,
                woman: answer.WomenFollower
            );

        }
    }  
}
