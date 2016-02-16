﻿using System.Collections.Generic;

namespace Steam.Models.DOTA2
{
    public class TeamInfoModel
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public long TimeCreated { get; set; }
        public string Rating { get; set; }
        public long Logo { get; set; }
        public long LogoSponsor { get; set; }
        public string CountryCode { get; set; }
        public string Url { get; set; }
        public int GamesPlayedWithCurrentRoster { get; set; }
        public uint AdminAccountId { get; set; }
        public IReadOnlyCollection<int> PlayerIds { get; set; }
        public IReadOnlyCollection<int> LeagueIds { get; set; }
    }
}