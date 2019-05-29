using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
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
            ProgressBar.IsIndeterminate = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void InspectorMain_OnClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Open_Spravka_Click(object sender, RoutedEventArgs e)
        { 
            MenuItem menu;
            if (sender as MenuItem != null)
            {
                menu = (MenuItem) sender;
            }
            else return; 
            SpravkaRazmetkaRed spravkaRazmetkaRed = new SpravkaRazmetkaRed(menu.Header.ToString());
            spravkaRazmetkaRed.Owner = this;
            spravkaRazmetkaRed.Show();
        }

        List<UserData> dataUser = new List<UserData>();
        
        private void ListSelect(object sender, SelectionChangedEventArgs e)
        {
            try
            { 
                ProgressBar.IsIndeterminate = true;
                dataUser.Clear();
                MySqlCommand myCommand = new MySqlCommand();
                MySqlDataReader MyDataReader;
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                string CommandText = "SELECT * FROM nzzGtRxVKL.UserData WHERE idUsers = " + allUsers[ListAdmin.SelectedIndex].IdUser + "";
                myCommand = new MySqlCommand(CommandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                   UserData data = new UserData(MyDataReader.GetInt32(0),MyDataReader.GetInt32(1),MyDataReader.GetString(2),MyDataReader.GetInt32(3),MyDataReader.GetInt32(4),MyDataReader.GetString(5),MyDataReader.GetString(6));
                   dataUser.Add(data);
                }
                MyDataReader.Close();

                NameFull_TextBox.Text = dataUser[0].fullName;
                UNP_TextBox.Text = dataUser[0].unp.ToString();
                KeyOrgana_TextBox.Text = dataUser[0].keyOrgana.ToString();
                Telefon_TextBox.Text = dataUser[0].telefon;
                God_TextBox.Text = dataUser[0].god;
                
                ProgressBar.IsIndeterminate = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Неизвестная ошибка " + e, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs ex)
        {
            if (NameFull_TextBox.Text != "" && UNP_TextBox.Text != "" && KeyOrgana_TextBox.Text != "" && Telefon_TextBox.Text != "" && God_TextBox.Text != "")
                {
                try
                {
                    int intik = Convert.ToInt32(UNP_TextBox.Text);
                    int intik1 = Convert.ToInt32(KeyOrgana_TextBox.Text);
                    try
                    {
                        string commantText = "UPDATE nzzGtRxVKL.UserData SET FullName = \""+ NameFull_TextBox.Text +"\", UNP = " + UNP_TextBox.Text +" ,KeyOrgana = " + KeyOrgana_TextBox.Text + " , KontaktniiTelefon = " + Telefon_TextBox.Text + ", GodViplati = "+ God_TextBox.Text +" WHERE idUserData = "+ dataUser[0].IdUserData +"";
                        MySqlCommand myCommand = new MySqlCommand();
                        MySqlDataReader MyDataReader;
                        MySqlConnection myConnection = new MySqlConnection(CONNECT);
                        myCommand = new MySqlCommand(commantText, myConnection);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Сохранено");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Не предвиденная ошибка" + e, "Ошибка", MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Введите число в UNP и Тип оргнана");
                }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        public void SetTex(Norma normas)
        {
            KeyOrgana_TextBox.Text = normas.Code.ToString();
        } 
        
        
        
        private void OrganButton_Click(object sender, RoutedEventArgs e)
        {
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka("Налоговые инспекции");
            spavkaRazmetka.Owner = this;
            spavkaRazmetka.Show();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindows addWind = new AddUserWindows(polsovatel);
            addWind.Owner = this;
            addWind.Show();
        }
    }
}
