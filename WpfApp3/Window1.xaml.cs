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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void rashet_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int c = Convert.ToInt32(TextBox2.Text);
            int count = 0; // Счетчик "Счастливых билетов".
            for (int i = 100000; i <= 999999; i++) // Цыкл пробегающий по всем 6-ти значнымцыфрам
            {
                int b = i;  // Несколько ЦЕЛОЧИСЛИННЫХ переменных
                a = a + (b / 100000);     // Сдесь а = 100000/100000 = 1, или, пример: а = 234567, тогда а/100000 = 2
                b = b % 100000;           // b = остаток от диления например: b = 123456, тогда b%100000 = 23456
                a = a + (b / 10000);      // Дальше повторяем опирации
                b = b % 10000;
                a = a + (b / 1000);
                b = b % 1000;
                c = c + (b / 100);
                b = b % 100;
                c = c + (b / 10);
                b = b % 10;
                c = c + (b / 1);
                if (a == c)     // Если первые три цыфры равны последним, плюсуем счетчик
                {
                    count++;
                }
            }
            MessageBox.Show("Колличество счасливых билетов " + count​);
        }

    }
}

