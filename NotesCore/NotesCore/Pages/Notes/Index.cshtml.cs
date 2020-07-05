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
    public class IndexModel : PageModel
    {
        private readonly NotesCore.Data.NotesCoreContext _context;

        public IndexModel(NotesCore.Data.NotesCoreContext context)
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
