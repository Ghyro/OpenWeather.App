﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public sealed class ProcessResponse : AppResponse
    {
        public List<AppResponse> Responses { get; set; }
    }
}
