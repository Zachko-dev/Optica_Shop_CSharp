using Optika_SvitZoryProgect.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optika_SvitZoryProgect.Data.Interfaces
{
   public  interface IGlasesCstegory
    { 
        IEnumerable<Category> AllCategories { get; }
    }
}
