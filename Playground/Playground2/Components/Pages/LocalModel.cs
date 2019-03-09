using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playground2.Components.Pages
{
    public class LocalModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression("^[0-9a-zA-Z_]+$")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(50)]
        [RegularExpression("^[a-zA-Z ]+$")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [RegularExpression("^[a-zA-Z ]+$")]
        public string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Range(typeof(DateTime), "1/1/1900", "1/1/2050")]
        public DateTime DOB { get; set; }

        public DateTime? Retired { get; set; }

        public int DogCount { get; set; }

        public int? CatCount { get; set; }

        public bool HasFish { get; set; }

        public bool? HasExoticFish { get; set; }

        public EmploymentStatus Status { get; set; }

        public enum EmploymentStatus
        {
            Unemployed = 0,
            FullTime = 1,
            PartTime = 2,
            NoTime = 3,
            AllTheTime = 4,
        }
    }
}
