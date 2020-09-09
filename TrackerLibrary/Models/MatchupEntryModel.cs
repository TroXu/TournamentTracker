using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezentuje jedna druzyne na pojedynku
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Reprezentuje jedna drużynę w pojedynku.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Reprezentuje wynik dla poszczególnych drużyn
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// reprezentuje pojedynek, z którego wyszedł
        /// ten zespół jako zwycięzca
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
