using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using netcore_ms_auth.Data;
using netcore_ms_auth.Models;

namespace netcore_ms_auth.Pages_ToDos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ToDo> ToDo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ToDo != null)
            {
                ToDo = await _context.ToDo.ToListAsync();
            }
        }
    }
}
