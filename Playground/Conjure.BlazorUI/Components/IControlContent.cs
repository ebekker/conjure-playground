using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public interface IControlContent
    {
        string Label { get; }

        LabelPosition? LabelPosition { get; }

        RenderFragment Content { get; }
    }
}
