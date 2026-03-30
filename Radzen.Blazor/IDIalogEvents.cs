using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radzen.Blazor
{
 /// <summary>
 /// On Save and on close events
 /// </summary>
    public interface IDialogEvents:IDisposable
    {
        /// <summary>
        /// The event called when the dialog Saved
        /// </summary>
          EventCallback<(Object sender,Guid Id)> OnSaved { get; set; }
        /// <summary>
        /// The event called when the dialog is closed
        /// </summary>
        EventCallback<(Object sender, Guid Id)> OnClosed { get; set; }
    }
 
}
