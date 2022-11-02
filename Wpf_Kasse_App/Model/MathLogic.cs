using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_Kasse_App.Model
{
    public class MathLogic
    {
        public static double Addition(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Division(double n1, double n2)
        {
            if (n2 == 0)
            {
                MessageBox.Show("Division by 0 is not supported"
                    , "Wrong Operation"
                    , MessageBoxButton.OK
                    , MessageBoxImage.Error);
                return 0;
            }

            return n1 / n2;
        }
    }
}
