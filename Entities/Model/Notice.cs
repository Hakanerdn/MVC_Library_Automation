using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Notice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Announcement { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
