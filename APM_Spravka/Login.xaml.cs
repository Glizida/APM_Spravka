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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        public List<User> users = new List<User>();
        string CommandText = "";

        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataReader MyDataReader;
       

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(CONNECT);
            try
            {
                if (LoginTexBox.Text != "" || PasswordTexBox.Text != "")
                {
                    CommandText = "SELECT * FROM nzzGtRxVKL.User where LoginUser = \""+LoginTexBox.Text+ "\";";
                    myCommand = new MySqlCommand(CommandText, myConnection);
                    myConnection.Open();
                    MyDataReader = myCommand.ExecuteReader();
                    while (MyDataReader.Read())
                    {
                        users.Add(new User(MyDataReader.GetInt32(0), MyDataReader.GetString(1), MyDataReader.GetString(2), MyDataReader.GetInt32(3)));
                    }
                    MyDataReader.Close();
                    if (users.Count != 0)
                    {
                        if (users[0].PasswordUser == PasswordTexBox.Text)
                        {
                            switch (users[0].LevelAccess)
                            {
                                case 1:
                                    MainWindow mainWindow = new MainWindow();
                                    mainWindow.Owner = this;
                                    mainWindow.Show();
                                    this.Hide();
                                    break;
                                case 2:
                                    MessageBox.Show("Admin2");
                                    break;
                                case 3:
                                    InspectorMain inspectorMain = new InspectorMain();
                                    inspectorMain.Owner = this;
                                    inspectorMain.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не верный логин или пароль", "Ошибка", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином не найден", "Ошибка", MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста введите логин и пароль");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Closed_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
