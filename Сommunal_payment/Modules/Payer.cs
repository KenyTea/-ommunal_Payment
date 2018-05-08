using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сommunal_payment.Manage
{ /*
Задается:
метраж помещения,
количество проживающих людей, 
сезон (осенью и зимой отопление дороже),
наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части)*/

    public enum Season // сезон (осенью и зимой отопление дороже)
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4
    }

    public enum Privileges // наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части)
    {
        NoOne = 0,
        VeteranOfLabour = 1,
        WarVeteran = 3,
    }

    public class Payer // плательщик
    {
        public int Area { get; set; } // метраж помещения
        public int Residents { get; set; } // количество проживающих людей
        public Season season { get; private set; } // сезон
        public Privileges privileges { get; private set; }
        public double WaterReading { get; set; }

        public Payer() {}

        public Payer(int area, int residents, int season, int privileges)
        {
            Random rand = new Random();
            Area = area;
            Residents = residents;
            this.season = (Season)season;
            this.privileges = (Privileges)privileges;
            WaterReading = rand.Next(3, 12);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Area - " + Area + "\nResidents - " + Residents + "\nSeason - " + season.ToString() + "\nPrivileges - " + privileges.ToString());
        }
    }
}
