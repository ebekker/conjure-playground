using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public class _ContainerContent : ComponentBase, IContainerContent
    {
        [Parameter]
        protected RenderFragment Content { get; set; }

        [Parameter]
        protected RenderFragment<IControlContent> Template { get; set; }

        RenderFragment<IControlContent> IContainerContent.Template => this.Template;
    }
}
