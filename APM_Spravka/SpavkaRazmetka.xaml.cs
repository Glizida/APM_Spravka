using System;
using System.Collections.Generic;
using System.Windows;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    public partial class SpavkaRazmetka : Window
    {

        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        public List<Norma> norma = new List<Norma>();
        public SpavkaRazmetka(string NamWindows)
        {
            InitializeComponent();
           
            Title = NamWindows;
            string CommandText = "";
            MySqlCommand myCommand = new MySqlCommand();
            MySqlDataReader MyDataReader;


            MySqlConnection myConnection = new MySqlConnection(CONNECT);

            try
            {
                switch (NamWindows)
                {
                    case "Документы, удостоверяющие личность":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Koddoc;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Класификаторы СОАТО":

                        break;
                    case "Типы улиц":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Tipul;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Налоговые инспекции":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Ngni;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Статусы плательщика":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Statplat;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Страны мира":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Country;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Авторские вознагрождения":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Author;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы по операциям с ценными бумагами":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Stock;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, не облагаемые в устан. пределах":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Taxlimit;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы от резидентов(не резидентов) ПВТ":
                        CommandText = "SELECT* FROM nzzGtRxVKL.Parkvt;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Стандартные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Standart;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Социальные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Social;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Имущественные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Property;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, полученные гражданами ЕАЭС":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Ecunion;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, полученные в Могилевской области":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Mogilev;";
                        listSpravka.ItemsSource = null;
                        myCommand = new MySqlCommand(CommandText, myConnection);
                        myConnection.Open();
                        MyDataReader = myCommand.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
                        }
                        MyDataReader.Close();
                        listSpravka.ItemsSource = norma;
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"Oшибка",MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Owner as InspectorMain != null)
            {
                if (listSpravka.SelectedIndex != 0)
                {
                    ((InspectorMain) Owner).SetTex(norma[listSpravka.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Вы ничего не выбрали ИМНС","Предупреждение",MessageBoxButton.OK,MessageBoxImage.Information);
                }
            }
            if (Owner as Setting != null)
            {
                if (listSpravka.SelectedIndex != 0)
                {
                    ((Setting) Owner).SetTex(norma[listSpravka.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Вы ничего не выбрали ИМНС", "Предупреждение", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
            if (Owner as Record != null)
            {
                if (listSpravka.SelectedIndex != 0)
                {
                    ((Record) Owner).SetText(norma[listSpravka.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Вы ничего не выбрали", "Предупреждение", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
            Owner.Show();
            Owner.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listSpravka.ItemsSource = null;
            List<Norma> pList = new List<Norma>();
            if (norma.Count != 0)
            {
                if (TextBox.Text != "")
                {
                    for (int i = 0; i < norma.Count; i++)
                    {
                        int x = norma[i].ToString().ToLower().IndexOf(TextBox.Text.ToLower());
                        if (x != -1)
                        {
                            pList.Add(norma[i]);
                        }
                    }
                }
            }
            listSpravka.ItemsSource = pList;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            listSpravka.ItemsSource = norma;
        }
    }
}
