using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radzen.Blazor
{
    public interface IDialogEvents:IDisposable
    {
          EventCallback<(Object sender,Guid Id)> OnSaved { get; set; }
          EventCallback<(Object sender, Guid Id)> OnClosed { get; set; }
    }
 
}
