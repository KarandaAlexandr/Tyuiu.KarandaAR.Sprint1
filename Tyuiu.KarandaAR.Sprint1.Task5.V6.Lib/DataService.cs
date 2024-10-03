using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarandaAR.Sprint1.Task5.V6.Lib
{
        public class DataService : ISprint1Task5V6
        {
            public int Calculate(int k)
            {
                int a = k % 7;
                if (a == 0)
                {
                    a = 7;
                }
                return a;
            }
        }
 }
