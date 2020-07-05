using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotesCore.Data;
using NotesCore.Models;

namespace NotesCore.Pages.Notes
{
    public class DetailsModel : PageModel
    {
        private readonly NotesCore.Data.NotesCoreContext _context;

        public DetailsModel(NotesCore.Data.NotesCoreContext context)
        {
            _context = context;
        }

        public Note Note { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Note.FirstOrDefaultAsync(m => m.Id == id);

            if (Note == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
