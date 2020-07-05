using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesCore.Models
{
    public class Note
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public string Value { get; set; }
    }
}
