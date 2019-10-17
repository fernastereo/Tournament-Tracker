using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {
    public class PrizeModel {
        public int placeNumber { get; set; }
        public string placeName { get; set; }
        public decimal prizeAmount { get; set; }
        public double pricePercentage { get; set; }
    }
}
