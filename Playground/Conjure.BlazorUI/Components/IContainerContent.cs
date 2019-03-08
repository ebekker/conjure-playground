using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public interface IContainerContent
    {
        LabelPosition? LabelPosition { get; }

        RenderFragment<IControlContent> Template{ get; }
    }
}
