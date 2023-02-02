using Core;
using DatabaseContext;
using DatabaseModels;
using Extractor1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Facade response = new Facade();
            try
            {
                await response.CreateParty("bash_mag", "Vneparlamentskie Partii");
                await response.CreateAllUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
