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
    public class RelationRepository : BasisRepository, IRelationRepository
    {
        public RelationRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphRelation> GetRelationAsync(int partyId)
        {
            var answer = await _context.Relations
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphRelation(
                married: answer.Married,
                notMarried: answer.NotMarried,
                haveFriend: answer.HaveFriend,
                civilMerriage: answer.CivilMerriage,
                engagement: answer.Engagement,
                activeResearch: answer.ActiveResearch
            );
        }
    }
}
