using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotesManager.Models
{
    public class NotesManagerContext : DbContext
    {
        public NotesManagerContext (DbContextOptions<NotesManagerContext> options)
            : base(options)
        {
        }

        public DbSet<NotesManager.Models.Note> Note { get; set; }
    }
}
