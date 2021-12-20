using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MultWinHome
{
    public partial class MainWindow : Window
    {
        int expectation;
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            expectation = 2;
            Expectation.Content = $"Ожидайте: {expectation} сек.";
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
                Expectation.Content = $"Ожидайте: {expectation} сек.";
            }
            else
            {
                dt.Stop();
                Expectation.Content = $"Новое окно.";
                var win = new Window();
                win.Show();
                Close();
            }
        }
        private void Content_Windows(object sender, EventArgs e)
        {
            dt.Start();
        }

    }
}
