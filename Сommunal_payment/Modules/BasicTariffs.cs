using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сommunal_payment.Manage
{
    /*на отопление (на 1 м2 площади),
      на воду (на 1 чел), 
      на газ (на 1 чел), 
      на текущий ремонт (на 1 м2 площади).*/

    public class BasicTariffs // счёт
    {
        public double Heating { get; set; }
        public double Water { get; set; }
        public double Gas { get; set; }
        public double Maintenance { get; set; }

        public BasicTariffs()
        {
            Heating = 86.06;
            Water = 55.56;
            Gas = 347.48;
            Maintenance = 54.8;
        }
    }
}
