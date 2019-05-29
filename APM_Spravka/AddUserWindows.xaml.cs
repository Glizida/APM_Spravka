using System;
using System.Windows;
using System.Windows.Controls;
using APM_Spravka.BD_Table;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    public partial class AddUserWindows : Window
    {
        public User polzovateli;
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        public AddUserWindows(User admin)
        {
            InitializeComponent();
            polzovateli = admin;
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            Password_Box.Text = "";
            Random random = new Random();
            string cript = "QWERTYUIOPASDFGHJKLZXCVBNNM1234567890qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 10; i++)
            {
                Password_Box.Text += cript[random.Next(0, cript.Length)];
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string accessLevel = "0";
            switch (ComboBoxx.Text)
            {
                case "Пользователь":
                    accessLevel = "1";
                    break;
                case "Администратор":
                    accessLevel = "2";
                    break;
                case "Инспектор":
                    accessLevel = "3";
                    break;
            }
            if (accessLevel == "1" || accessLevel == "2" || accessLevel == "3")
            {
                try
                {
                    
                    string connectString = "INSERT nzzGtRxVKL.User SET LoginUser = \"" + Login_Box.Text +
                                           "\", PasswordUser = \"" + Password_Box.Text + "\", LeverAccess = " +
                                           accessLevel +
                                           ", CreaterID =" + polzovateli.IdUser + "";
                    MySqlCommand myCommand = new MySqlCommand();
                    MySqlDataReader MyDataReader;
                    MySqlConnection myConnection = new MySqlConnection(CONNECT);
                    myCommand = new MySqlCommand(connectString, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Сохранено");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Не предвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}