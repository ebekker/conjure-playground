using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public interface IContainerContent
    {
        RenderFragment<IControlContent> Template{ get; }
    }
}
