using Conjure.BlazorUI.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conjure.BlazorUI.ValidatedControls
{
    public class _ValidatedTextBox<T> : ComponentBase
    {
        [CascadingParameter]
        protected EditContext CascadedEditContext { get; set; }

        [Parameter]
        protected string Label { get; set; }

        [Parameter]
        protected LabelPosition? LabelPosition { get; set; }

        [Parameter]
        protected T Value { get; set; }

        [Parameter]
        protected EventCallback<T> ValueChanged { get; set; }

        [Parameter]
        protected bool MultiLine { get; set; }

        protected string ValueAsString
        {
            get => (string)(object)Value;
            set => Value = (T)(object)value;
        }

        protected async Task OnValueChanged(T value)
        {
            await ValueChanged.InvokeAsync(value);
            CascadedEditContext.Validate();
        }
        //protected EventCallback<string> ValueAsStringChanged =>
        //    (EventCallback<string>)(object)ValueChanged;

        //protected EventCallback<DateTime?> ValueAsDateChanged =>
        //    (EventCallback<DateTime?>)(object)ValueChanged;
    }
}
