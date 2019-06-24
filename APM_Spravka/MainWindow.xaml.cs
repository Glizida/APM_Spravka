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
using APM_Spravka.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {
        public User polsovatel;
        public List<UserTable> userTables = new List<UserTable>();
    
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataReader MyDataReader;
        
        public string CommandText;


        public MainWindow(User user)
        {
            InitializeComponent();
            polsovatel = user;
            LoadPolzovateli();
        }

        public void LoadPolzovateli()
        {
            try
            {
                CommandText = $"SELECT * FROM nzzGtRxVKL.UserTable WHERE idUser = {polsovatel.IdUser}";
                userTables.Clear();
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                ListZapisei.ItemsSource = null;
                myCommand = new MySqlCommand(CommandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    UserTable godno = new UserTable(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2),MyDataReader.GetString(3), MyDataReader.GetString(4), MyDataReader.GetString(5), MyDataReader.GetString(6),MyDataReader.GetString(7));
                    userTables.Add(godno);
                }
                MyDataReader.Close();
                ListZapisei.ItemsSource = userTables;
            }
            catch (Exception e)
            {
                MessageBox.Show("Не известная ошибка" + e, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Open_Setting_Click(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting(polsovatel);
            setting.Owner = this;
            setting.Show();
            this.IsEnabled = false;
        }

        private void Open_Spravka_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu;
            if (sender as MenuItem != null)
            {
                menu = (MenuItem) sender;
            }
            else return; 
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(menu.Header.ToString());
            spavkaRazmetka.Owner = this;
            spavkaRazmetka.Show();
            this.IsEnabled = false;
        }

        private void Open_Record_Click(object sender, RoutedEventArgs e)
        {
            
                Record record = new Record(polsovatel,null, false);
                record.Owner = this;
                record.Show();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            OProgramme oProgramme = new OProgramme();
            oProgramme.Show();
        }


        private void Otchet_Click(object sender, RoutedEventArgs e)
        {
            Othet othet = new Othet();
            othet.Show();
        }
        
        private void Open_RedRecord_Click(object sender, RoutedEventArgs e)
        {
            if (ListZapisei.SelectedItem != null)
            {
                Record record = new Record(polsovatel,(UserTable)ListZapisei.SelectedItem, true);
                record.Owner = this;
                record.Show(); 
            }
            else
            {
                Record record = new Record(polsovatel,null, false);
                record.Owner = this;
                record.Show();
            }
        }

        private void OpenSpravkaPrinting_Click(object sender, RoutedEventArgs e)
        {
            if (ListZapisei.SelectedItem != null)
            {
                Othet othet = new Othet();
                othet.Show();
            }
            else
            {
                MessageBox.Show("Выберите запись по которой нужно вывести отчет", "Предупреждение",MessageBoxButton.OK,MessageBoxImage.Information);

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

           
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?","Вопрос",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                string commantText =
                    $"DELETE FROM nzzGtRxVKL.UserTable WHERE idSviazi = {((UserTable) ListZapisei.SelectedItem).IdSviazi};";
                myCommand = new MySqlCommand(commantText, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MyDataReader.Close();
                LoadPolzovateli();
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не известная ошибка" + exception, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
