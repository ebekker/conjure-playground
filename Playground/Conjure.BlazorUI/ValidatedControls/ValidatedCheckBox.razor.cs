using Conjure.BlazorUI.Components;
using Conjure.BlazorUI.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conjure.BlazorUI.ValidatedControls
{
    public class _ValidatedCheckBox<T> : LabeledControlBase
    {
        [CascadingParameter]
        protected EditContext CascadedEditContext { get; set; }

        [Parameter]
        protected T Value { get; set; }

        [Parameter]
        protected EventCallback<T> ValueChanged { get; set; }

        protected bool ValueAsBool => (bool)(object)Value;

        protected string ValueAsString => ((bool?)(object)Value)?.ToString()??"";

        protected async Task ValueAsStringChanged(string value)
        {
            bool? bValue = null;
            if (bool.TryParse(value, out var b))
                bValue = b;
            await ValueChanged.InvokeAsync((T)(object)bValue);
        }
    }
}
