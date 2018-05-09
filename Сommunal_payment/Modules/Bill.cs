using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сommunal_payment.Manage
{
    public class Bill
    {
        public string ToHeating { get; set; }
        public string ToWater { get; set; }
        public string ToGas { get; set; }
        public string ToMaintenance { get; set; }

        public double PayHeating { get; set; }
        public double PayWater { get; set; }
        public double PayGas { get; set; }
        public double PayMaintenance { get; set; }

        public double TotalPay { get; set; }

    }


}
