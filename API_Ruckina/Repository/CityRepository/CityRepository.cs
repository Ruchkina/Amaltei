//using AppAmalt.Dto;
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
    public class CityRepository : BasisRepository, ICityRepository
    {
        public CityRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphCity> GetCityAsync(int partyId)
        {
            var answer = await _context.ValueCitis
                .Include(u => u.City)
                .Where(p => p.PartyId == partyId).ToListAsync(); 
            if (answer == null)
                throw new Exception();

            List<CityModal> DataCityForGraph = new List<CityModal>();
            foreach (ValueCity oneCityData in answer)
            {
                DataCityForGraph.Add(new CityModal(oneCityData.City.Name, oneCityData.Value));
            }

            return new GraphCity(DataCityForGraph);

        }
    }
}
