using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground1.Components.Pages
{
    public interface IContainer
    {
        //void Add(IContainedItem item);
        //void Remove(IContainedItem item);

        RenderFragment<IContainedItem> GetTemplate();
    }

    public interface IContainedItem
    {
        //RenderFragment GetContent();

        string GetLabel { get; set; }

        string GetValue { get; set; }

        RenderFragment GetContent { get; set; }
    }
}
