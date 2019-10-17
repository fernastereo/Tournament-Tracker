﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {
    /// <summary>
    /// Respresents one team in a matchup
    /// </summary>
    public class MatchupEntryModel {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel teamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner
        /// </summary>
        public MatchupModel parentMatchup { get; set; }
    }
}
