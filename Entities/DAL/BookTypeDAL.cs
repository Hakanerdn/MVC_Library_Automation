using Entities.Model;
using Entities.Model.Context;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DAL
{
    public class BookTypeDAL : GenericRepository<LibraryContext, BookType>
    {
    }
}
