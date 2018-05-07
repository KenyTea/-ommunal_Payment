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
        public string[] name = new[] { "To Heating ", "To Water", "To Gas ", "To Maintenance" };
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
                if(payer.season == (Season)1 || payer.season == (Season)2)
                {
                    bil.ToPay =  tariffs.Heating * area;
                    bil.Name = name[0];
                    bil.ToPay = tariffs.Water * residents;
                    bil.Name = name[1];
                    bil.ToPay =  tariffs.Gas * residents;
                    bil.Name = name[2];
                    bil.ToPay =  tariffs.Maintenance * area;
                    bil.Name = name[3];

                    bill.Add(bil);
                }
                else if (payer.season == (Season)3 || payer.season == (Season)4)
                {
                    
                    bil.ToPay = ((tariffs.Heating) * 1.5) * area;
                    bil.Name = name[0];
                    bil.ToPay = tariffs.Water * residents;
                    bil.Name = name[1];
                    bil.ToPay = tariffs.Gas * residents;
                    bil.Name = name[2];
                    bil.ToPay = tariffs.Maintenance * area;
                    bil.Name = name[3];

                    bill.Add(bil);
                }
            }
            else if(payer.privileges == (Privileges)1)
            {

            }

        }



    }
}
