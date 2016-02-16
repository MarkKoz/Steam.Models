﻿using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class StorePrefabModel
    {
        public object Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyCollection<StoreConfigModel> Config { get; set; }
    }
}