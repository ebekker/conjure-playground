using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground2.Components.Pages
{
    public class LocalModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

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
