using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сommunal_payment.Manage;

namespace Сommunal_payment.Modules
{
    public class Service
    {
        public List<Bill> bill { get; set; }

        public Service()
        {
            bill = new List<Bill>();
        }

        public Bill this[int i]
        {
            get { return bill[i]; }
        }

        public void Count(int area, int residents)
        {

            Bill bil = new Bill();
            Payer payer = new Payer();
            BasicTariffs tariffs = new BasicTariffs();

            if (payer.privileges == (Privileges)0)
            {
                if (payer.season == (Season)1 || payer.season == (Season)2)
                {
                    bil.PayHeating = tariffs.Heating * area;
                    bil.ToHeating = "To Heating";
                    bil.PayWater = tariffs.Water * payer.WaterReading;
                    bil.ToWater = "To Water";
                    bil.PayGas = tariffs.Gas * residents;
                    bil.ToGas = "To Gas";
                    bil.PayMaintenance = tariffs.Maintenance * area;
                    bil.ToMaintenance = "To Maintatence";
                    bil.TotalPay = bil.PayHeating + bil.PayWater + bil.PayGas + bil.PayMaintenance;

                    bill.Add(bil);
                }
                else if (payer.season == (Season)3 || payer.season == (Season)4)
                {
                    bil.PayHeating = ((tariffs.Heating) * 1.5) * area;
                    bil.ToHeating = "To Heating";
                    bil.PayWater = tariffs.Water * payer.WaterReading;
                    bil.ToWater = "To Water";
                    bil.PayGas = tariffs.Gas * residents;
                    bil.ToGas = "To Gas";
                    bil.PayMaintenance = tariffs.Maintenance * area;
                    bil.ToMaintenance = "To Maintatence";
                    bil.TotalPay = bil.PayHeating + bil.PayWater + bil.PayGas + bil.PayMaintenance;

                    bill.Add(bil);
                }
            }

            else if (payer.privileges == (Privileges)1)
            {
                bil.PayHeating = tariffs.Heating * area;
                bil.ToHeating = "To Heating";
                bil.PayWater = tariffs.Water * payer.WaterReading;
                bil.ToWater = "To Water";
                bil.PayGas = tariffs.Gas * residents;
                bil.ToGas = "To Gas";
                bil.PayMaintenance = tariffs.Maintenance * area;
                bil.ToMaintenance = "To Maintatence";
                bil.TotalPay = (bil.PayHeating + bil.PayWater + bil.PayGas + bil.PayMaintenance) * 0.30;

                bill.Add(bil);
            }

            else if (payer.privileges == (Privileges)2)
            {
                bil.PayHeating = tariffs.Heating * area;
                bil.ToHeating = "To Heating";
                bil.PayWater = tariffs.Water * payer.WaterReading;
                bil.ToWater = "To Water";
                bil.PayGas = tariffs.Gas * residents;
                bil.ToGas = "To Gas";
                bil.PayMaintenance = tariffs.Maintenance * area;
                bil.ToMaintenance = "To Maintatence";
                bil.TotalPay = (bil.PayHeating + bil.PayWater + bil.PayGas + bil.PayMaintenance) * 0.30;

                bill.Add(bil);
            }


        }





    }
}
