using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dyblik_Click(object sender, RoutedEventArgs e)
        {
            List<string> list = (TextBox.Text.Split().Distinct().ToList());
            TextBox.Text = "";
            foreach (string s in list)
            {
                TextBox.Text += s + " ";
                
            }

        }
        private void Sorkirovka_Click(object sender, RoutedEventArgs e)
        {
            List<string> a = new List<string>();//Список целочисленных значений

            string[] txt = TextBox.Text.Split(' ');//Деление введенного пользователем текста на части символом ' '(Пробел)

            for (int i = 0; i < txt.Count(); i++)//Пробегаемся по всем кусочкам
            {
                try // Пробуем Добавить в список цифру, конвертированную в int
                {
                    a.Add(Convert.ToString(txt[i]));
                }
                catch { }//Если не получилось - пропускаем(ничего не делаем)
            }

            a.Sort();//Сортируем

            TextBox.Text = "";//Очищаем TextBox2

            for (int i = 0; i < a.Count(); i++)//Добавляем все элементы списка во второй TextBox
                TextBox.Text += a[i] + " ";
        }

        private void Hifrator_Click(object sender, RoutedEventArgs e)
        {
            string data = TextBox.Text;
            char[] charc = data.ToCharArray();
            Array.Reverse(charc);
            int i;
            string emptystr = string.Empty;
            for (i = 0; i < charc.Length; i++)
            {
                emptystr += charc[i];
            }
            TextBox.Text = emptystr.ToString();
        }

        
        private void Trimer_Click(object sender, RoutedEventArgs e)
        {
            string s = TextBox.Text;
            TextBox.Text = s.Substring(0, s.IndexOf(" ") + 1);
            s = s.Remove(0, s.IndexOf(" "));
            s = s.Replace("  ", " ");
            TextBox.Text += s;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
