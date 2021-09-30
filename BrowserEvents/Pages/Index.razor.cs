using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserEvents.Pages
{
    public class IndexBase : ComponentBase
    {
        protected List<BreadcrumbItem> ListBreadcrumbs { get; set; }

        public List<Teste> Lista { get; set; }

        public IndexBase()
        {
            ListBreadcrumbs = new List<BreadcrumbItem>();

            //Lista = new List<Teste>();

            //for (int i = 0; i < 100000; i++)
            //{
            //    Lista.Add(new Teste(i, false));
            //}
        }

        protected override void OnInitialized()
        {
            ListBreadcrumbs.Add(new BreadcrumbItem("Home", href: "/", disabled: true));
        }
    }

    public class Teste
    {
        public Teste(int Valor, bool isOpen)
        {
            this.Valor = Valor;
            this.isOpen = isOpen;
        }

        public int Valor { get; set; }
        public bool isOpen { get; set; }
    }
}
