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
using static APM_Spravka.RecordCS;
using static APM_Spravka.RecordCSIndex;

namespace APM_Spravka
{
    /// <summary>
    /// Логика взаимодействия для Record.xaml
    /// </summary>
    public partial class Record : Window
    {
        public User polzovatel;
        public UserTable userTablee;
        public bool korrekt;

        public string nameWindow;
        
        public string CONNECT = "Database=nzzGtRxVKL;Data Source=remotemysql.com;User Id=nzzGtRxVKL;Password=OCqp3u3YNf";
        MySqlCommand myCommand = new MySqlCommand();
        MySqlDataReader MyDataReader;

        private int doxod = 0;
        private int doxodTable1 = 0;
        private int razdel2 = 0;
        private int vznosiTable1 = 0;
        private int vznosiTable2 = 0;
        private int vznosiTable3 = 0;


        public Record(User user,UserTable userTable, bool korekt)
        {
            
            InitializeComponent();
            polzovatel = user;
            if (userTable != null)
            {
                userTablee = userTable;
                GetRazdel2(userTablee);
                GetDoxod(userTablee);
                GetVznos(userTablee);
            }
            korrekt = korekt;
        }

        public void GetDoxod(UserTable table)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                string commandText = $"SELECT * FROM nzzGtRxVKL.Doxod WHERE idUser = {table.IdSviazi};";
                string commandText2 = $"SELECT * FROM nzzGtRxVKL.DoxodTable WHERE idDoxod= {table.IdSviazi};";
                myCommand = new MySqlCommand(commandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    doxod = MyDataReader.GetInt32(0);
                    Avtor_ListBox.Items.Add(MyDataReader.GetString(3));
                    OperCB_ListBox.Items.Add(MyDataReader.GetString(4));
                }
                MyDataReader.Close();
                myCommand = new MySqlCommand(commandText2, myConnection);
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    doxodTable1 = MyDataReader.GetInt32(0);
                    DoxodIanvari.Text = MyDataReader.GetString(2);
                    DoxodFevrali.Text = MyDataReader.GetString(3);
                    DoxodMart.Text = MyDataReader.GetString(4);
                    DoxodAprel.Text = MyDataReader.GetString(5);
                    DoxodMai.Text = MyDataReader.GetString(6);
                    DoxodIyul.Text = MyDataReader.GetString(7);
                    DoxodIyun.Text = MyDataReader.GetString(8);
                    DoxodAvgust.Text = MyDataReader.GetString(9);
                    DoxodSentiabr.Text = MyDataReader.GetString(10);
                    DoxodOktiabri.Text = MyDataReader.GetString(11);
                    DoxodNoiabr.Text = MyDataReader.GetString(12);
                    DoxodDekabri.Text = MyDataReader.GetString(13);
                }
                MyDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GetVznos(UserTable table)
        {
 try
            {
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                string commandText = $"SELECT * FROM nzzGtRxVKL.VznosiTabl1 WHERE idDoxod = {table.IdSviazi};";
                string commandText2 = $"SELECT * FROM nzzGtRxVKL.VznosiTabl2 WHERE idDoxod= {table.IdSviazi};";
                string commandText3 = $"SELECT * FROM nzzGtRxVKL.VznosiTabl3 WHERE idDoxod= {table.IdSviazi};";
                myCommand = new MySqlCommand(commandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    vznosiTable1 = MyDataReader.GetInt32(0);
                    Vznos1Ianvari.Text = MyDataReader.GetString(2);
                    Vznos1Fevrali.Text = MyDataReader.GetString(3);
                    Vznos1Mart.Text  = MyDataReader.GetString(4);
                    Vznos1Aprel.Text  = MyDataReader.GetString(5);
                    Vznos1Mai.Text  = MyDataReader.GetString(6);
                    Vznos1Iyul.Text = MyDataReader.GetString(7);
                    Vznos1Iyun.Text  = MyDataReader.GetString(8);
                    Vznos1Avgust.Text = MyDataReader.GetString(9);
                    Vznos1Sentiabr.Text  = MyDataReader.GetString(10);
                    Vznos1Oktiabri.Text  = MyDataReader.GetString(11);
                    Vznos1Noiabr.Text = MyDataReader.GetString(12);
                    Vznos1Dekabri.Text = MyDataReader.GetString(13);
                    IndexVznos1Ianvari.Text = MyDataReader.GetString(14);
                    IndexVznos1Fevrali.Text = MyDataReader.GetString(15);
                    IndexVznos1Mart.Text  = MyDataReader.GetString(16);
                    IndexVznos1Aprel.Text  = MyDataReader.GetString(17);
                    IndexVznos1Mai.Text  = MyDataReader.GetString(18);
                    IndexVznos1Iyul.Text = MyDataReader.GetString(19);
                    IndexVznos1Iyun.Text  = MyDataReader.GetString(20);
                    IndexVznos1Avgust.Text = MyDataReader.GetString(21);
                    IndexVznos1Sentiabr.Text  = MyDataReader.GetString(22);
                    IndexVznos1Oktiabri.Text  = MyDataReader.GetString(23);
                    IndexVznos1Noiabr.Text = MyDataReader.GetString(24);
                    IndexVznos1Dekabri.Text = MyDataReader.GetString(25);
                }
                MyDataReader.Close();
                myCommand = new MySqlCommand(commandText2, myConnection);
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    vznosiTable2 = MyDataReader.GetInt32(0);
                    Vznos2Ianvari.Text = MyDataReader.GetString(2);
                    Vznos2Fevrali.Text = MyDataReader.GetString(3);
                    Vznos2Mart.Text  = MyDataReader.GetString(4);
                    Vznos2Aprel.Text  = MyDataReader.GetString(5);
                    Vznos2Mai.Text  = MyDataReader.GetString(6);
                    Vznos2Iyul.Text = MyDataReader.GetString(7);
                    Vznos2Iyun.Text  = MyDataReader.GetString(8);
                    Vznos2Avgust.Text = MyDataReader.GetString(9);
                    Vznos2Sentiabr.Text  = MyDataReader.GetString(10);
                    Vznos2Oktiabri.Text  = MyDataReader.GetString(11);
                    Vznos2Noiabr.Text = MyDataReader.GetString(12);
                    Vznos2Dekabri.Text = MyDataReader.GetString(13);
                }
                MyDataReader.Close();
                myCommand = new MySqlCommand(commandText3, myConnection);
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    vznosiTable3 = MyDataReader.GetInt32(0);
                    Vznos3Ianvari.Text = MyDataReader.GetString(2);
                    Vznos3Fevrali.Text = MyDataReader.GetString(3);
                    Vznos3Mart.Text  = MyDataReader.GetString(4);
                    Vznos3Aprel.Text  = MyDataReader.GetString(5);
                    Vznos3Mai.Text  = MyDataReader.GetString(6);
                    Vznos3Iyul.Text = MyDataReader.GetString(7);
                    Vznos3Iyun.Text  = MyDataReader.GetString(8);
                    Vznos3Avgust.Text = MyDataReader.GetString(9);
                    Vznos3Sentiabr.Text  = MyDataReader.GetString(10);
                    Vznos3Oktiabri.Text  = MyDataReader.GetString(11);
                    Vznos3Noiabr.Text = MyDataReader.GetString(12);
                    Vznos3Dekabri.Text = MyDataReader.GetString(13);
                    IndexVznos3Ianvari.Text = MyDataReader.GetString(14);
                    IndexVznos3Fevrali.Text = MyDataReader.GetString(15);
                    IndexVznos3Mart.Text  = MyDataReader.GetString(16);
                    IndexVznos3Aprel.Text  = MyDataReader.GetString(17);
                    IndexVznos3Mai.Text  = MyDataReader.GetString(18);
                    IndexVznos3Iyul.Text = MyDataReader.GetString(19);
                    IndexVznos3Iyun.Text  = MyDataReader.GetString(20);
                    IndexVznos3Avgust.Text = MyDataReader.GetString(21);
                    IndexVznos3Sentiabr.Text  = MyDataReader.GetString(22);
                    IndexVznos3Oktiabri.Text  = MyDataReader.GetString(23);
                    IndexVznos3Noiabr.Text = MyDataReader.GetString(24);
                    IndexVznos3Dekabri.Text = MyDataReader.GetString(25);
                }
                MyDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GetRazdel2(UserTable table)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(CONNECT);
                string commandText = $"SELECT * FROM nzzGtRxVKL.Rasdel2 WHERE idSviazi = {table.IdSviazi};";
                myCommand = new MySqlCommand(commandText, myConnection);
                myConnection.Open();
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    razdel2 = MyDataReader.GetInt32(0);
                    UNP_TextBox.Text = MyDataReader.GetString(2);
                    Status_TextBox.Text = MyDataReader.GetString(3);
                    if (MyDataReader.GetInt32(4) == 0)
                    {
                        KeyVorkOsn_RadioButton.IsChecked = true;
                        KeyVorkNeOns_RadioButton.IsChecked = false;
                    }
                    else
                    {
                        KeyVorkOsn_RadioButton.IsChecked = false;
                        KeyVorkNeOns_RadioButton.IsChecked = true;
                    }

                    Familii_TextBox.Text = MyDataReader.GetString(5);
                    Imia_TextBox.Text = MyDataReader.GetString(6);
                    Otchestvo_TextBox.Text = MyDataReader.GetString(7);
                    KodDoc_TextBox.Text = MyDataReader.GetString(8);
                    Seria_TextBox.Text = MyDataReader.GetString(9);
                    Nomer_TextBox.Text = MyDataReader.GetString(10);
                    DataViachi_DatePicker.Text = Convert.ToString(MyDataReader.GetDateTime(20));
                    KemVidan_TextBox.Text = MyDataReader.GetString(11);
                    Idificationi_TextBox.Text = MyDataReader.GetString(12);
                    XataIndex_TextBox.Text = MyDataReader.GetString(13);
                    Gorod_TextBox.Text = MyDataReader.GetString(14);
                    TipUlic_TextBox.Text = MyDataReader.GetString(15);
                    NameYlica_TextBox.Text = MyDataReader.GetString(16);
                    Dom_TextBox.Text = MyDataReader.GetString(17);
                    Korpus_TextBox.Text = MyDataReader.GetString(18);
                    Kvartira_TextBox.Text = MyDataReader.GetString(19);
                }
                MyDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
            Owner.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void SetText(Norma norma)
        {
            try
            { 
                switch (nameWindow)
                {
                    case "Документы, удостоверяющие личность":
                        KodDoc_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Типы улиц":
                        TipUlic_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Авторские вознагрождения":
                        Avtor_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Доходы по операциям с ценными бумагами":
                        CinieBumagi_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Доходы, не облагаемые в устан. пределах":
                        DoxodNeOblg_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Социальные вычеты":
                        DoxodNeOblg_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Доходы от резидентов(не резидентов) ПВТ":
                        RezidentPVT_TextBox.Text = norma.Code.ToString();
                        break;
                    case "Доходы, полученные в Могилевской области":
                        RezidentPVT_TextBox.Text = norma.Code.ToString();
                        break; 
                    case "Статусы плательщика":
                        RezidentPVT_TextBox.Text = norma.Code.ToString();
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private void KodDoc_Button_OnClick(object sender, RoutedEventArgs e)
        {
            nameWindow = "Документы, удостоверяющие личность";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }

        private void TipUlicButton_OnClick(object sender, RoutedEventArgs e)
        {
            nameWindow = "Типы улиц";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
           
        }

        private void AvtorButton_OnClick(object sender, RoutedEventArgs e)
        {
            nameWindow = "Авторские вознагрождения";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;

        }

        private void CinieBumagiButton_Click(object sender, RoutedEventArgs e)
        {
            nameWindow = "Доходы по операциям с ценными бумагами";
           SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }

        private void DoxodNeOblgButton_Click(object sender, RoutedEventArgs e)
        {
            nameWindow = "Доходы, не облагаемые в устан. пределах";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }

        private void SocVichetButton_OnClick(object sender, RoutedEventArgs e)
        {
            nameWindow = "Социальные вычеты";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }

        private void RezidentPVTButton_OnClick(object sender, RoutedEventArgs e)
        {
             nameWindow = "Доходы от резидентов(не резидентов) ПВТ";
             SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
             spavkaRazmetka.Show();
             spavkaRazmetka.Owner = this;
        }

        private void MogilevButton_OnClick(object sender, RoutedEventArgs e)
        {
            nameWindow = "Доходы, полученные в Могилевской области";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }

        private void StatusButton_OnClick(object sender, RoutedEventArgs e)
        {
            
            nameWindow = "Статусы плательщика";
            SpavkaRazmetka spavkaRazmetka = new SpavkaRazmetka(nameWindow);
            spavkaRazmetka.Show();
            spavkaRazmetka.Owner = this;
        }
    }
}
