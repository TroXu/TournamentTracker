using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Zajete miejsce druzyny
        /// </summary>
        public int PlaceNumber { get; set; }
       
        /// <summary>
        /// Nazwa miejsca (mistrz,wicemistrz etc.)
        /// </summary>
        public string PlaceName { get; set; }
       
        /// <summary>
        /// Wysokosc Sumy wygranej
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Procentowa wysokosc sumy wygranej
        /// </summary>
        public double PrizePrecentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePrecentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePrecentageValue = 0;
            double.TryParse(prizePrecentage, out prizePrecentageValue);
            PrizePrecentage = prizePrecentageValue;


        }
    }
}
