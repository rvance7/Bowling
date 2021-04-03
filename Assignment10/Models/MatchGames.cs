﻿using System;
using System.Collections.Generic;

namespace Assignment10.Models
{
    public partial class MatchGames
    {
        public long MatchId { get; set; }
        public long GameNumber { get; set; }
        public long? WinningTeamId { get; set; }

        public virtual TourneyMatches Match { get; set; }
    }
}
