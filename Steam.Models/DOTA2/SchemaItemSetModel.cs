﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaItemSetModel
    {
        public string RawName { get; set; }

        public string Name { get; set; }

        public string StoreBundleName { get; set; }

        public IList<string> Items { get; set; }
    }
}
