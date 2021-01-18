using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eZeljeznice.MobileApp.Models;

namespace eZeljeznice.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Putovanja, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Putovanja:
                        MenuPages.Add(id, new NavigationPage(new PutovanjaPage()));
                        break;
                    case (int)MenuItemType.MojProfil:
                        MenuPages.Add(id, new NavigationPage(new MojProfil()));
                        break;
                    case (int)MenuItemType.HistorijaRezervacija:
                        MenuPages.Add(id, new NavigationPage(new HistorijaRezervacija()));
                        break;
                    case (int)MenuItemType.Kontakt:
                        MenuPages.Add(id, new NavigationPage(new Kontakt()));
                        break;
                    case (int)MenuItemType.Obavještenja:
                        MenuPages.Add(id, new NavigationPage(new Obavjestenja()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}