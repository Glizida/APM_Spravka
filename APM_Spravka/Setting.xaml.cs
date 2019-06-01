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
using APM_Spravka.BD_Table;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    /// <summary>
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public string CommandText;
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";

        public UserData userData  = new UserData();
        public User user = new User();
        
        public bool newUserData;
        
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataReader MyDataReader;
        
        public Setting(User user)
        {
            InitializeComponent();
            this.user = user;
            
            try
            {
                CommandText = $"SELECT * FROM UserData where idUsers = {this.user.IdUser.ToString()}";
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                myCommand = new MySqlCommand(CommandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    userData.IdUserData = MyDataReader.GetInt32(0);
                    userData.IdUser = MyDataReader.GetInt32(1);
                    userData.fullName = MyDataReader.GetString(2);
                    userData.unp = MyDataReader.GetInt32(3);
                    userData.keyOrgana = MyDataReader.GetInt32(4);
                    userData.telefon = MyDataReader.GetString(5);
                    userData.god = MyDataReader.GetString(6);
                }
                MyDataReader.Close();
                myConnection.Close();

                if (userData.IdUserData != null || userData.IdUserData != 0)
                {
                    UNP_Box.Text = userData.unp.ToString();
                    FullName_Box.Text = userData.fullName;
                    KeyOrgana_TextBox.Text = userData.keyOrgana.ToString();
                    Telefon_Box.Text = userData.telefon;
                    God_Box.Text = userData.god;

                    newUserData = false;
                }
                else
                {
                    newUserData = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка" + e, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.IsEnabled = true;
            Owner.Show();
        }

        public void SetTex(Norma normas)
        {
            KeyOrgana_TextBox.Text = normas.Code.ToString();
        }
        
        private void OpenOrgan_Click(object sender, RoutedEventArgs e)
        {
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka("Налоговые инспекции");
            spavkaRazmetka.Owner = this;
            spavkaRazmetka.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    switch (newUserData)
                    {
                    case true:
                        CommandText = $"INSERT nzzGtRxVKL.UserData SET idUsers = {user.IdUser}, FullName = '{FullName_Box.Text}', UNP = {Convert.ToInt32(UNP_Box.Text)},KeyOrgana = {Convert.ToInt32(KeyOrgana_TextBox.Text)}, KontaktniiTelefon = {Telefon_Box.Text}'', GodViplati = {God_Box.Text}";
                        MySqlConnection myConnection1 = new MySqlConnection(CONNECT);
                        myCommand = new MySqlCommand(CommandText, myConnection1);
                        myConnection1.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection1.Close();
                        break;
                    case false:
                        CommandText = $"UPDATE nzzGtRxVKL.UserData SET FullName = '{FullName_Box.Text}', UNP = {Convert.ToInt32(UNP_Box.Text)}, KeyOrgana = {Convert.ToInt32(KeyOrgana_TextBox.Text)}, KontaktniiTelefon = '{Telefon_Box.Text}', GodViplati = '{God_Box.Text}' where idUserData = {userData.IdUserData}";
                        MySqlConnection myConnection2 = new MySqlConnection(CONNECT);
                        myCommand = new MySqlCommand(CommandText, myConnection2);
                        myConnection2.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection2.Close();
                        break;
                    }

                    MessageBox.Show("Сохраннено успешно", "Сохранено", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка обращения к БД, пожалуйста проверте правилность ввода данных", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не предвиденная ошибка" + exception, "Ошибка", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
