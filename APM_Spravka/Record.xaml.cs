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
        
        public Record(User user,UserTable userTable, bool korekt)
        {
            InitializeComponent();
            polzovatel = user;
            if (userTable != null)
            {
                userTablee = userTable;
            }
            korrekt = korekt;
            
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
