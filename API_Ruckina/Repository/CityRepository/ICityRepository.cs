using AppAmalt.Dto;
using AppAmalt.ModelsGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public interface ICityRepository
    {
        Task<GraphCity> GetCityAsync(int idParty);
    }
}
