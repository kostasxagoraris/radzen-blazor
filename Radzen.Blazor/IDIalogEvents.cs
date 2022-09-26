using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radzen.Blazor
{
    public interface IDialogEvents
    {
          EventCallback<Guid> OnSaved { get; set; }
          EventCallback<Guid> OnClosed { get; set; }
    }
}
