using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Putovanja,
        MojProfil,
        Obavještenja,
        Kontakt,
        HistorijaRezervacija
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
