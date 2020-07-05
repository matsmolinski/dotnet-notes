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
    public class IndexModel : PageModel
    {
        private readonly NotesManager.Models.NotesManagerContext _context;

        public IndexModel(NotesManager.Models.NotesManagerContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }

        public async Task OnGetAsync()
        {
            Note = await _context.Note.ToListAsync();
        }
    }
}
