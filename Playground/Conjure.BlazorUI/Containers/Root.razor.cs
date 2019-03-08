using Conjure.BlazorUI.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Containers
{
    public class _Root : ComponentBase
    {
        [Parameter]
        protected object Model { get; set; }

        [Parameter]
        protected LabelPosition DefaultLabelPosition { get; set; } = LabelPosition.LeftAligned;

        [Parameter]
        protected RenderFragment ChildContent { get; set; }
    }
}
