using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Barcodeno { get; set; }
        public int BookTypeId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public int StockNumber { get; set; }
        public int PageNumber { get; set; }
        public string Description { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }

    }
}
