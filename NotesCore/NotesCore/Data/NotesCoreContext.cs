using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesCore.Models;

namespace NotesCore.Data
{
    public class NotesCoreContext : DbContext
    {
        public NotesCoreContext (DbContextOptions<NotesCoreContext> options)
            : base(options)
        {
        }

        public DbSet<NotesCore.Models.Note> Note { get; set; }
    }
}
