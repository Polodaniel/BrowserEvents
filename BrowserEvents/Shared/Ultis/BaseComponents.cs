using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserEvents.Shared.Ultis
{
    public class BaseComponents : ComponentBase
    {
        [Inject]
        public IJSRuntime JS { get; set; }
    }
}
