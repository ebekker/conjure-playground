using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Containers
{
    public class _RowsLayout : ComponentBase
    {
        [Parameter]
        protected RenderFragment ChildContent { get; set; }
    }
}
