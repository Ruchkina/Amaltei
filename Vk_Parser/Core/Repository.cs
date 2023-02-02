using DatabaseContext;
using DatabaseModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class Repository
    {
        private DatabaseContexts _context;

        public Repository(DatabaseContexts context)
        {
            _context = context;
        }



        public async Task AddFollower(Follower data)
        {
            if (!(_context.Follower.Any(s => s.Id == data.Id)))
            {
                try
                {
                    await _context.AddAsync(data);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task AddParty(int _idParty, string _nameParty)
        {
            if (!(_context.Follower.Any(s => s.Id == _idParty)))
            {
                try
                {
                    Party party = new Party(_idParty, _nameParty);
                    await _context.AddAsync(party);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task AddSubscription(int idFollower, int idParty)
        {
            if (!(_context.Follower.Any(s => s.Id == idFollower)))
            {
                try
                {
                    int idSubscription = !_context.Subscription.Any() ? 0 : _context.Subscription.Max(i => i.Id) + 1;
                    Subscription data = new Subscription(idSubscription, idFollower, idParty);
                    await _context.AddAsync(data);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public void DeleteElement(int id1)
        {
            Subscription u = _context.Subscription.Find(id1);
            int id = u.FollowerId;
            Follower fgh = _context.Follower.Find(id);
            _context.Follower.Remove(fgh);
            _context.SaveChanges();
        }


    }
}
