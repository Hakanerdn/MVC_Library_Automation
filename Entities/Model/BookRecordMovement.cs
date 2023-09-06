using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class BookRecordMovement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string ActionTaken { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
