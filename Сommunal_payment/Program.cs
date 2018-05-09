using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сommunal_payment.Manage;
using Сommunal_payment.Modules;

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
            int areaa = 0, residentss, saesonn, privilegess;

            Console.WriteLine("Enter area");
            int.TryParse(Console.ReadLine(), out areaa);
            Console.Clear();
            Console.WriteLine("Enter the number of residents");
            int.TryParse(Console.ReadLine(), out residentss);
            Console.Clear();
            Console.WriteLine("Enter saeson (Spring = 1, summer = 2, autumn = 3, winter = 4)");
            int.TryParse(Console.ReadLine(), out saesonn);
            Console.Clear();
            Console.WriteLine("Enter privileges (no benefits = 0, veteran of war = 1, veteran of war = 2) ");
            int.TryParse(Console.ReadLine(), out privilegess);

            Payer payer = new Payer(areaa, residentss, saesonn, privilegess);
            payer.PrintInfo();

            Console.ReadLine();
            Console.Clear();

            Service serv = new Service();
            serv.Count(payer);

            serv.TotalPrint();

        }
    }
}
