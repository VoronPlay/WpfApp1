using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            /*double x = double.Parse(X.Text);
            string F1 = string.Empty;
            string F2 = string.Empty;*/
            double F1, F2, X3;
            
            //получаем данные для трасировки
            double X1 = Convert.ToDouble(x1.Text);
           double X2 = Convert.ToDouble(x2.Text);
            double h1 = Convert.ToDouble(H1.Text);

            //считаем значения по формуле
            //2 sin2x

            while (X1<=X2)
            {
                X3 = (X1 * 180) / Math.PI;
                F1 = Math.Sin(2 * X3);
                F2 = 0.5 * (Math.Sin(X3) + Math.Cos(X3));

                if (F1 == F2)
                            {
                                Y1.Text += "F1="+Convert.ToString(F1)+" F2="+ Convert.ToString(F2)+Environment.NewLine;
                                Y2.Text += "Истина, значение равно " + F1 + Environment.NewLine;
                    
                                //MessageBox.Show("Истина, значение равно " +F1);
                            }
                else
                            {
                                Y1.Text += "F1=" + Convert.ToString(F1) + " F2=" + Convert.ToString(F2) + Environment.NewLine;
                                Y2.Text += "Ложь"+  Environment.NewLine;
                                //MessageBox.Show("Ложно, значения равны " +F1 +"и "+F2);
                            }
                X1 = X1 + h1;
            }
            
        }
    }
}
