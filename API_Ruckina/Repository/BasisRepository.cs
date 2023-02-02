using DatabaseContext;

namespace AppAmalt.Repository
{
    public class BasisRepository
    {
        protected readonly DatabaseContexts _context;
        public BasisRepository(DatabaseContexts context)
        {
            _context = context;
        }

    }
}
