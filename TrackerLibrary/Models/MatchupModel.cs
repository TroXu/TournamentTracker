using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezentuje jeden pojedynek w turnieju
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Zestaw druzyn, ktore biora udzial
        /// w tym pojedynku
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Wygrany Pojedynku
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Czescia, ktorej rundy jest ten pojedynek
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
