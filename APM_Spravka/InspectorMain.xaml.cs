using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для InspectorMain.xaml
    /// </summary>
    public partial class InspectorMain : Window
    {
        public User polsovatel;
        public List<User> allUsers = new List<User>();

        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";


        public InspectorMain(User user)
        {
            InitializeComponent();
            polsovatel = user;

            string CommandText = "";

            MySqlCommand myCommand = new MySqlCommand();
            MySqlDataReader MyDataReader;
            MySqlConnection myConnection = new MySqlConnection(CONNECT);

            CommandText = "SELECT * FROM nzzGtRxVKL.User";
            ListAdmin.ItemsSource = null;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open();
            MyDataReader = myCommand.ExecuteReader();
            while (MyDataReader.Read())
            {
                User govno = new User(MyDataReader.GetInt32(0), MyDataReader.GetString(1), MyDataReader.GetString(2),
                    MyDataReader.GetInt32(3), MyDataReader.GetInt32(4));
                allUsers.Add(govno);
            }
            MyDataReader.Close();
            ListAdmin.ItemsSource = allUsers;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void InspectorMain_OnClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
