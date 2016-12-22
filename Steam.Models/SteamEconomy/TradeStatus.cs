﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public enum TradeStatus
    {
        Init = 0,
        PreCommitted = 1,
        Committed = 2,
        Complete = 3,
        Failed = 4,
        PartialSupportRollback = 5,
        FullSupportRollback = 6,
        SupportRollbackSelective = 7,
        RollbackFailed = 8,
        RollbackAbandoned = 9,
        InEscrow = 10,
        EscrowRollback = 11
    }
}
