using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/* Давайте начнем с примера:

    У мужчины есть довольно старая машина стоимостью 2000 долларов. 
    Он увидел подержанную машину стоимостью 8000 долларов.
    Он хочет сохранить свою старую машину до тех пор, пока не сможет купить подержанную.

    Он думает, что сможет экономить 1000 долларов каждый месяц,
    но цены на его старую машину и на новую снижаются на 1,5 процента в месяц. Более того, этот процент потерь увеличивается на 0,5 процента 
    в конце каждых двух месяцев.

    Нашему сотруднику трудно произвести все эти расчеты.

    Сколько месяцев ему потребуется, чтобы накопить достаточно денег, чтобы купить машину, которую он хочет, и сколько денег у него останется?
*/

/* Detail of the above example:
    end month 1: percent_loss 1.5 available -4910.0
    end month 2: percent_loss 2.0 available -3791.7999...
    end month 3: percent_loss 2.0 available -2675.964
    end month 4: percent_loss 2.5 available -1534.06489...
    end month 5: percent_loss 2.5 available -395.71327...
    end month 6: percent_loss 3.0 available 766.158120825...
    return [6, 766] or (6, 766)
 */

namespace ConsoleApp
{
    internal class BuyCar
    {
        /// <param name="startPriceOld"> Old car price </param>
        /// <param name="startPriceNew"> New car price </param>
        /// <param name="savingPerMonth"> Saved money </param>
        public int[] nbMonths(double startPriceOld, double startPriceNew, double savingPerMonth, double percentLossByMonth)
        {
            const double percentageIncrease = 0.5d;// Percentage increase by 0.5 every two months
            int numberMount = 0;
            double available = startPriceOld - startPriceNew;

            while (available < 0)
            {
                ++numberMount;
                if (numberMount % 2 == 0)
                {
                    percentLossByMonth += percentageIncrease;
                }

                startPriceOld = startPriceOld - startPriceOld * (percentLossByMonth / 100);
                startPriceNew = startPriceNew - startPriceNew * (percentLossByMonth / 100);
                available = startPriceOld - startPriceNew + savingPerMonth * numberMount;
            }

            int[] finalResulte = {numberMount, (int)Math.Round(available)}; // {mounts, available money}
            return finalResulte;
        }
    }
}
