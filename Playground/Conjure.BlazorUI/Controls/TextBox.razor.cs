using Conjure.BlazorUI.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Controls
{
    public class _TextBox : ComponentBase
    {
        [Parameter]
        protected string Label { get; set; }

        [Parameter]
        protected LabelPosition? LabelPosition { get; set; }

        [Parameter]
        protected string Value { get; set; }

        [Parameter]
        protected EventCallback<string> ValueChanged { get; set; }
    }
}
