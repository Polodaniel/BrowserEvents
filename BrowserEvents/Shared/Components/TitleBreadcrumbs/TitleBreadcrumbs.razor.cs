using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserEvents.Shared.Components.TitleBreadcrumbs
{
    public class TitleBreadcrumbsBase : ComponentBase
    {
        [Parameter]
        public string TitlePage { get; set; }

        [Parameter]
        public List<BreadcrumbItem> ListBreadcrumbs { get; set; }
    }
}
