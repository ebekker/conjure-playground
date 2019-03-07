using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground1.Components
{
    public class SimpleForm
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int NumCats { get; set; }

        public int? Age { get; set; }

        public DateTime? DoB { get; set; }

        public bool IsActive { get; set; }

        public bool? IsPlaying { get; set; }
    }
}
