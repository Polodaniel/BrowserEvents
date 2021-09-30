using BrowserEvents.Shared.Ultis;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserEvents.Shared.Components.VibrateBrowser
{
    public class VibrateBrowserBase : BaseComponents
    {
        protected int Time { get; set; }

        public VibrateBrowserBase() =>
            Time = 1;

        protected async void ToExecuteVibrate() 
        {
            var Convert = Time * 1000;

            await JS.InvokeVoidAsync("ToExecuteVibrate", Convert);
        }
    }
}
