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

namespace APM_Spravka
{
    /// <summary>
    /// Логика взаимодействия для InspectorMain.xaml
    /// </summary>
    public partial class InspectorMain : Window
    {
        public InspectorMain()
        {
            InitializeComponent();
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Open_Setting_Click(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting();
            setting.Owner = this;
            setting.Show();
            this.IsEnabled = false;
        }

        private void Open_Spravka_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu;
            if (sender as MenuItem != null)
            {
                menu = (MenuItem)sender;
            }
            else return;
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(menu.Header.ToString());
            spavkaRazmetka.Owner = this;
            spavkaRazmetka.Show();
            this.IsEnabled = false;
        }
    }
}
