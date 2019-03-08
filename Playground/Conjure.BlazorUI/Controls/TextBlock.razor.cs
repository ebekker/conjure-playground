using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Containers
{
    public class _TextBlock : ComponentBase
    {
        [Parameter]
        protected object Model { get; set; }

        [Parameter]
        protected RenderFragment ChildContent { get; set; }
    }
}
