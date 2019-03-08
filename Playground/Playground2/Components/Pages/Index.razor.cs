using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground2.Components.Pages
{
    public class _Index : ComponentBase
    {
        protected LocalModel MyModel { get; set; } = new LocalModel();

        protected string ModelAsJson => JsonConvert.SerializeObject(MyModel, Formatting.Indented);

        public class LocalModel
        {
            public string Username { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime DOB { get; set; }

            public int DogCount { get; set; }

            public int CatCount { get; set; }

            public bool HasFish { get; set; }

            public bool? HasExoticFish { get; set; }
        }
    }
}
