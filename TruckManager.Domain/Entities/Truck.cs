using System.ComponentModel.DataAnnotations;

namespace TruckManager.Domain.Entities
{
    public class Truck: Base
    {
        [Required]
        public string TruckModel { get; set; }
        [Required]
        public int YearManufactured { get; set; }
        [Required]
        public int YearModel { get; set; }
    }
}
