using System;
using System.Collections.Generic;
using System.Windows;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    public partial class SpravkaRazmetkaRed : Window
    {
        public string nameTable = "";

        public string TitleWindow;
        
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        public List<Norma> norma = new List<Norma>();
        public SpravkaRazmetkaRed(string NamWindows)
        {
            InitializeComponent();
           
            Title = NamWindows;
            TitleWindow = NamWindows;

            LoadData();
        }

        public void LoadData()
        {
            norma.Clear();
            string CommandText = "";
            try
            {
                switch (TitleWindow)
                {
                    case "Документы, удостоверяющие личность":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Koddoc;";
                        nameTable = "Koddoc";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Класификаторы СОАТО":

                        break;
                    case "Типы улиц":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Tipul;";
                        nameTable = "Tipul";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Налоговые инспекции":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Ngni;";
                        nameTable = "Ngni";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Статусы плательщика":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Statplat;";
                        nameTable = "Statplat";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Страны мира":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Country;";
                        nameTable = "Country";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Авторские вознагрождения":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Author;";
                        nameTable = "Author";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы по операциям с ценными бумагами":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Stock;";
                        nameTable = "Stock";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, не облагаемые в устан. пределах":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Taxlimit;";
                        nameTable = "Taxlimit";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы от резидентов(не резидентов) ПВТ":
                        CommandText = "SELECT* FROM nzzGtRxVKL.Parkvt;";
                        nameTable = "Parkvt";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Стандартные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Standart;";
                        listSpravka.ItemsSource = null;
                        nameTable = "Stndart";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Социальные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Social;";
                        nameTable = "Social";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Имущественные вычеты":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Property;";
                        nameTable = "Property";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, полученные гражданами ЕАЭС":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Ecunion;";
                        nameTable = "Ecunion";
                        Zapros(CommandText);
                        listSpravka.ItemsSource = norma;
                        break;
                    case "Доходы, полученные в Могилевской области":
                        CommandText = "SELECT * FROM nzzGtRxVKL.Mogilev;";
                        nameTable = "Mogilev";
                        Zapros(CommandText);
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

        public void Zapros(string CommandText)
        {
            MySqlCommand myCommand = new MySqlCommand();
            MySqlDataReader MyDataReader;
            MySqlConnection myConnection = new MySqlConnection(CONNECT);
            
            listSpravka.ItemsSource = null;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open();
            MyDataReader = myCommand.ExecuteReader();
            while (MyDataReader.Read())
            {
                norma.Add(new Norma(MyDataReader.GetInt32(0), MyDataReader.GetInt32(1), MyDataReader.GetString(2)));
            }
            MyDataReader.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
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

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            if (listSpravka.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите элемент для редактирования", "Предупреждение", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            { RedSpravka redspravka = new RedSpravka(norma[listSpravka.SelectedIndex],listSpravka.SelectedIndex,nameTable);
            redspravka.Owner = this;
            redspravka.Show();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddSpravka addSpravka = new AddSpravka(nameTable);
            addSpravka.Owner = this;
            addSpravka.Show();
        }
    }
}