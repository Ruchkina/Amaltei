using DatabaseContext;
using DatabaseModels;
using Extractor1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Facade
    {
        readonly private Extractor _extractor;
        private Repository _repository;

        private List<string> idUsers;
        readonly private int _idParty;


        public Facade()
        {
            var connectionString = "User ID=postgres; Password=123; Server=localhost; Port=5432; Database=AppVK";
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContexts>();
            optionsBuilder.UseNpgsql(connectionString);
            DatabaseContexts _context = new DatabaseContexts(optionsBuilder.Options);

            _repository = new Repository(_context);
            _extractor = new Extractor();
            
            idUsers = new List<string>();
            _idParty = !_context.Party.Any() ? 1 : _context.Party.Max(i => i.Id);
 


        }
        public async Task CreateParty(string idGroupParty, string name)
        {
            idUsers = await _extractor.FetchInfoGroup(idGroupParty);
            await _repository.AddParty(_idParty, name);
        }

        public async Task CreateAllUserInfo()
        {
            Follower follower = new Follower();
            foreach (string id in idUsers)
            {
                Response unvalidUserInfo = await _extractor.FetchInfoUser(int.Parse(id));
                if (CheckerCorrectData.IsCorrectData(unvalidUserInfo))
                {
                    follower = ConvertToValidFollowers.Convert(unvalidUserInfo);
                    await _repository.AddFollower(follower);
                    await _repository.AddSubscription(follower.Id, _idParty);
                }

            }
        }

    }
}
