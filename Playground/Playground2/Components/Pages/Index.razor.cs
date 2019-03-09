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
    }
}
