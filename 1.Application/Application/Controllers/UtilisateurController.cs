using Application.Models;

namespace Application.Controllers
{
    public class UtilisateurController
    {
        private readonly TestBdContext _context;

        public UtilisateurController(ILogger<UtilisateurController> logger, TestBdContext context)
        {
            _context = context;
        }

    }
}
