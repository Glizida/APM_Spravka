using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using APM_Spravka_Admin.BD_Table;
using MySql.Data.MySqlClient;

namespace APM_Spravka
{
    public partial class RedSpravka : Window
    {
        public Norma listNorma;
        public string nameTable = "";
        public int selectIdd;
        
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        
        public RedSpravka(Norma normas, int selectId, string name)
        {
            InitializeComponent();
            listNorma = normas;
            nameTable = name;
            selectIdd = selectId;

            CodeBox.Text = listNorma.Code.ToString();
            ContentBox.Text = listNorma.Content.ToString();
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
                        string updateString = "UPDATE nzzGtRxVKL." + nameTable + " set Code = " +
                                              CodeBox.Text.ToString() + ", Content = \"" + ContentBox.Text +
                                              "\" where id = " +
                                              listNorma.Id + ";";
                        MySqlCommand myCommand = new MySqlCommand();
                        MySqlDataReader MyDataReader;
                        MySqlConnection myConnection = new MySqlConnection(CONNECT);
                        myCommand = new MySqlCommand(updateString, myConnection);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Добавленно");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ошибка, возможно запись с таким кодом уже существует", "Ошибка",
                            MessageBoxButton.OK, MessageBoxImage.Error);
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