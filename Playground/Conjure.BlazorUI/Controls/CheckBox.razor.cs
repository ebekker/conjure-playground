using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Controls
{
    public class _CheckBox : ComponentBase
    {
        [Parameter]
        protected bool Value { get; set; }

        [Parameter]
        protected EventCallback<bool> ValueChanged { get; set; }
    }
}
