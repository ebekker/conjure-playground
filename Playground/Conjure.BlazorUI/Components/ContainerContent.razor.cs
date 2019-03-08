using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public class _ContainerContent : ComponentBase, IContainerContent
    {
        [CascadingParameter]
        protected IControlContent ParentControl { get; set; }

        [Parameter]
        protected LabelPosition? LabelPosition { get; set; }

        [Parameter]
        protected RenderFragment Content { get; set; }

        [Parameter]
        protected RenderFragment<IControlContent> Template { get; set; }

        LabelPosition? IContainerContent.LabelPosition => this.LabelPosition ?? this.ParentControl?.LabelPosition;

        RenderFragment<IControlContent> IContainerContent.Template => this.Template;
    }
}
