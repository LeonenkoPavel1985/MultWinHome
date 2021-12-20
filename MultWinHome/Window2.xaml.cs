using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace MultWinHome
{
     public partial class Window2 : Window
    {
        int expectation;
        DispatcherTimer dt = new DispatcherTimer();
        public Window2()
        {
            InitializeComponent();
        }
        public Window2(string Surname, string Name)
        {
            InitializeComponent();
            Label_Surname.Content = Surname;
            Label_Name.Content = Name;
            expectation = 5;
            Button_Exit.Content = $"Завершение ({expectation})";
        }
        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            EndApp();
        }
        private void Load_win(object sender, RoutedEventArgs e)
        {
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Tick += new EventHandler(dispatcherExpectation);
        }
        private void dispatcherExpectation(object? sender, EventArgs e)
        {
            if (expectation > 0)
            {
                expectation--;
                Button_Exit.Content = $"Завершение ({expectation})";
            }
            else
            {
                EndApp();
            }
        }
        private void EndApp()
        {
            dt.Stop();
            Button_Exit.Content = $"Завершение.";
            Close();
        }
        private void Content_Windows(object sender, EventArgs e)
        {
            dt.Start();
        }
    }
}
