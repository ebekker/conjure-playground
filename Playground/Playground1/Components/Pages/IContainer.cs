using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground1.Components.Pages
{
    public interface IContainer
    {
        RenderFragment<IContainedItem> GetTemplate();
    }

    public interface IContainedItem
    {
        string GetLabel { get; set; }

        RenderFragment GetContent { get; set; }
    }
}
