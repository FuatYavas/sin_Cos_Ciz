using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeödevi1
{
    internal class Matematik
    {
        public static double mutlakDeger(double sayi)
        {
            if (sayi >= 0) return sayi;
            else return -1 * sayi;
        }

        public static double karekok(double sayi)
        {

            double x = sayi/ 2;

            while (true)
            {
                double yeni_x = (x + sayi / x) / 2;
                if (Math.Abs(yeni_x - x) < 0.00001)
                {
                    break;
                }
                x = yeni_x;
            }
            return x;

        }
        
        public static double max(double[] sayilar)
        {
            double max = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > max)
                {
                    max = sayilar[i];
                }
            }

            return max;
        }

        public static double sincosHesapla(double x)
        {
            double epsilon = 1e-15; 
            double sinus = 0.0;
            double sign = 1.0;
            double term = x;
            int n = 1;

            while (Math.Abs(term) > epsilon)
            {
                sinus += sign * term;
                sign = -sign;
                term *= x * x / ((2 * n) * (2 * n + 1));
                n++;
            }

            return sinus;
        }
    }
}

