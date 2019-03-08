using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.Components
{
    public class _ControlContent : ComponentBase, IControlContent
    {
        [CascadingParameter]
        protected IContainerContent ParentContainer { get; set; }

        [Parameter]
        protected string Label { get; set; }

        [Parameter]
        protected LabelPosition? LabelPosition { get; set; }

        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        string IControlContent.Label => this.Label;

        LabelPosition? IControlContent.LabelPosition => this.LabelPosition ?? ParentContainer.LabelPosition;

        RenderFragment IControlContent.Content => this.ChildContent;
    }
}
