using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotesManager.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public string Value { get; set; }
    }
}
