﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts
{
    public class PaginationQuery
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 10;
    }
}
