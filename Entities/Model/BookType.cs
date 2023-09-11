using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class BookType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Book> Book { get; set; }
    }
}
