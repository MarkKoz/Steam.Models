﻿namespace Steam.Models.GameEconomy
{
    public class EconItemAttributeModel
    {
        public int DefIndex { get; set; }
        public object Value { get; set; }

        public double FloatValue { get; set; }

        public EconItemAttributeAccountInfoModel AccountInfo { get; set; }
    }
}