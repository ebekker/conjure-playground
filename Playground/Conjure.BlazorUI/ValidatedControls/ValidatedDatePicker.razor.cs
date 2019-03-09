using Conjure.BlazorUI.Components;
using Conjure.BlazorUI.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.BlazorUI.ValidatedControls
{
    public class _ValidatedDatePicker<T> : LabeledControlBase
    {
        [CascadingParameter]
        protected EditContext CascadedEditContext { get; set; }

        [Parameter]
        protected T Value { get; set; }

        [Parameter]
        protected EventCallback<T> ValueChanged { get; set; }

        protected string ValueAsString
        {
            get => (string)(object)Value;
            set => Value = (T)(object)value;
        }
    }
}
