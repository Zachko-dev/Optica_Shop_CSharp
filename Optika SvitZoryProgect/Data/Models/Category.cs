﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optika_SvitZoryProgect.Data.Models
{
    public class Category
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string desk { set; get; }

        public List<Glases> Glasess { set; get; }

    }
}
