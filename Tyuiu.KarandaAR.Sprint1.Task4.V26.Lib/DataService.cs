using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarandaAR.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.PI / 2 - Math.Atan(x+y)) / (Math.Pow(Math.E, y + x)), 3) * -1 + 0.001;
        }
    }
}
