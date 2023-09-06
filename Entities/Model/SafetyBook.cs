using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class SafetyBook
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public int BookNumber { get; set; }
        public DateTime BookReceivedDate { get; set; }
        public DateTime BookReturnDate { get; set; }
    }
}
