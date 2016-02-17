﻿using Steam.Models.GameEconomy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaModel
    {
        public SchemaGameInfoModel GameInfo { get; set; }
        
        public IList<SchemaRarityModel> Rarities { get; set; }
        
        public IList<SchemaQualityModel> Qualities { get; set; }
        
        public IList<SchemaColorModel> Colors { get; set; }
        
        public IList<SchemaPrefabModel> Prefabs { get; set; }
        
        public IList<SchemaItemModel> Items { get; set; }
        
        public IList<SchemaItemSetModel> ItemSets { get; set; }
        
        public IList<SchemaItemAutographModel> ItemAutographs { get; set; }
    }
}
