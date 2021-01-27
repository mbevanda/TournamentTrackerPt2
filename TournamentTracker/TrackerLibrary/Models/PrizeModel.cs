using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// The numeric indentifier for the place ( 2 for second place, etc.)
        /// </summary>
        [Display(Name = "Place Number")]
        [Range(1, 100)]
        [Required]
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The fiendly name for the place ( second place, first runneer up, etc.)
        /// </summary>
        [Display(Name = "Place Name")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed amount this place earns or zero if it is not used.
        /// </summary>
        [Display(Name = "Prize Amount")]
        [DataType(DataType.Currency)]
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take or 
        /// zero if it is not used. The percentage is a fraction of 1 ( so 0.5 for 
        /// 50%).
        /// </summary>
        [Display(Name = "Prize Percentage")]
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue; 
        }
    }
}
