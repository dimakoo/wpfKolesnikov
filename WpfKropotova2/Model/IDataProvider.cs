﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKropotova2.Model
{
    interface IDataProvider
    {
        IEnumerable<Sweet> GetSweets();
    }
}
