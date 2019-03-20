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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APM_Spravka
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting();
            setting.Owner = this;
            setting.Show();
            this.IsEnabled = false;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka();
            spavkaRazmetka.Owner = this;
            spavkaRazmetka.Show();
            this.IsEnabled = false;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Record record = new Record();
            record.Owner = this;
            record.Show();;
            this.IsEnabled = false;
        }
    }
}
