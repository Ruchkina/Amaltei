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
    public class EducationRepository : BasisRepository, IEducationRepository
    {
        public EducationRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphEducation> GetEducationAsync(int partyId)
        {
            var answer = await _context.Educations
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphEducation(
                university: answer.University,
                work: answer.Work,
                school: answer.School
            );

        }
    }
}
