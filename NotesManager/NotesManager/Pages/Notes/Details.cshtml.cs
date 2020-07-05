using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotesManager.Models;

namespace NotesManager.Pages.Notes
{
    public class DetailsModel : PageModel
    {
        private readonly NotesManager.Models.NotesManagerContext _context;

        public DetailsModel(NotesManager.Models.NotesManagerContext context)
        {
            _context = context;
        }

        public Note Note { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Note.FirstOrDefaultAsync(m => m.ID == id);

            if (Note == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
