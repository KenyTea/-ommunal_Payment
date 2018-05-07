using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сommunal_payment.Manage;

namespace Сommunal_payment
{
    /* Тема: Индексаторы и свойства.

1.	Написать программу, рассчитывающую сумму коммунальных платежей:
есть базовые тарифы 
на отопление (на 1 м2 площади),
на воду (на 1 чел), 
на газ (на 1 чел), 
на текущий ремонт (на 1 м2 площади).
Задается:
метраж помещения,
количество проживающих людей, 
сезон (осенью и зимой отопление дороже),
наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части).
Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, Итого. Посчитать итоговую сумму.
*/
    class Program
    {
        static void Main(string[] args)
        {

            Payer payer = new Payer(32, 2, 1, 1);
            payer.PrintInfo();


        }
    }
}
