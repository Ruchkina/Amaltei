using DatabaseContext;
using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class CheckerCorrectData
    {
        public static bool IsCorrectData(Response response)
        {
            return response.bdate != null && response.sex != 0 /*&& !(context.Follower.Any(s => s.Id == response.id))*/ && ConvertBirth.GetBirthYear(response) != 0;
        }
    }
}
