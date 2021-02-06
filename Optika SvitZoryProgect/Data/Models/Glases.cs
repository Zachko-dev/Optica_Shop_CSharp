using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optika_SvitZoryProgect.Data.Models
{
    public class Glases
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesk { set; get; }

        public string longDesk { set; get; }

        public string img { set; get; }

        public ushort prise { set; get; }

        public bool isFavorite { set; get; }

        public bool avaiLable { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}

