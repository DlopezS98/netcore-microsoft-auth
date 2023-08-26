using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using netcore_ms_auth.Data;
using netcore_ms_auth.Models;

namespace netcore_ms_auth.Pages_ToDos
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ToDo ToDo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ToDo == null)
            {
                return NotFound();
            }

            var todo = await _context.ToDo.FirstOrDefaultAsync(m => m.Id == id);

            if (todo == null)
            {
                return NotFound();
            }
            else 
            {
                ToDo = todo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.ToDo == null)
            {
                return NotFound();
            }
            var todo = await _context.ToDo.FindAsync(id);

            if (todo != null)
            {
                ToDo = todo;
                _context.ToDo.Remove(ToDo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
