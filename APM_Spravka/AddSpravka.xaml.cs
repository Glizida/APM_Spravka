using System;
using System.ComponentModel;
using System.Windows;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    public partial class AddSpravka : Window
    {       
        public Norma listNorma;
        public string nameTable = "";
        public int selectIdd;
        
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        
        public AddSpravka(string name)
        {
            InitializeComponent();
            //listNorma = normas;
            nameTable = name;
            //selectIdd = selectId;
        }

        public void Save()
        {
            if (ContentBox.Text != "" && CodeBox.Text != "")
            {
                try
                {
                    int intik = Convert.ToInt32(CodeBox.Text);
                    try
                    {
                        string updateString = "INSERT nzzGtRxVKL." + nameTable + " SET Code = " +
                                              CodeBox.Text.ToString() + ", Content = \"" + ContentBox.Text + "\"";
                        MySqlCommand myCommand = new MySqlCommand();
                        MySqlDataReader MyDataReader;
                        MySqlConnection myConnection = new MySqlConnection(CONNECT);
                        myCommand = new MySqlCommand(updateString, myConnection);
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
                    MessageBox.Show("Введите число в код");
                }
            }
        }
        
        private void SeveButton_Click(object sender, RoutedEventArgs e)
        {
;        Save();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        private void RedSpravka_OnClosing(object sender, CancelEventArgs e)
        {
            Owner.Show();
            ((SpravkaRazmetkaRed)Owner).LoadData();
        }
    }
}