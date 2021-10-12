using System;

namespace TruckManager.Application.Dtos
{
    public class TruckDto
    {
        public Guid Id { get; set; }
        public string TruckModel { get; set; }
        public int YearManufactured { get; set; }
        public int YearModel { get; set; }
    }
}
