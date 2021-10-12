using System;
using System.ComponentModel.DataAnnotations;

namespace TruckManager.Domain.Entities
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
