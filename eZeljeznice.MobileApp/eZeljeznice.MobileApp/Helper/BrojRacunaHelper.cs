using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace eZeljeznice.MobileApp.Helper
{
    public class BrojRacunaHelper
    {
        public static string GenerisiBrojRacuna()
        {
            string startWith = DateTime.Now.ToString("M/d/yy");
            Random generator = new Random();
            string r = generator.Next(0, 99).ToString("D2");
            string accountNumber = startWith + r;
            return accountNumber;
        }
    }
}
