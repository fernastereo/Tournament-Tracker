using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {
    /// <summary>
    /// Represents one match in the Tournament.
    /// </summary>
    public class MatchupModel {
        /// <summary>
        /// Represents the set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represnts the winner of the match.
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// Represents which round this match is a part of
        /// </summary>
        public int matchupRound { get; set; }
    }
}
