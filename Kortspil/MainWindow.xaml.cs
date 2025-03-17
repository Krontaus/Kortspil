using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Kortspil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Kortene er hentet fra https://acbl.mybigcommerce.com/52-playing-cards/
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Kort.Text == "")
            {
                MessageBox.Show("Du skal indtaste et kortnummer"); // undersøger om feltet er tomt
                return;
            }
            else if (!int.TryParse(Kort.Text, out _))
            {
                MessageBox.Show("Du skal indtaste et tal fra 1-52"); // undersøger om der er indtastet et tal
                return;
            }
            else
            {
            int kortnummer = Convert.ToInt32(Kort.Text);
            string filnavn = FindBillede(kortnummer);
            string url = $"/Billeder/{filnavn}";
            Uri uri = new (url, UriKind.Relative);
            BitmapImage image = new(uri);
           
            Billede.Source = image;
            }
        }

        private string FindBillede(int kortnummer)
        {
            string resultat = "";
            string farve = "";
            string vaerdig = "";
                if (kortnummer < 1 || kortnummer > 52) // undersøger om kortnummeret er indenfor intervallet
                {
                    MessageBox.Show("Kortnummeret skal være mellem 1 og 52");
                    resultat = "Purple_back.jpg";
                }
                else
                {
                    if (kortnummer >= 1 && kortnummer <= 13 ) farve = "spar";
                    else if (kortnummer >= 14 && kortnummer <= 26) farve = "ruder";
                    else if (kortnummer >= 27 && kortnummer <= 39) farve = "klør";
                    else if (kortnummer >= 40 && kortnummer <= 52) farve = "hjerter";

                    if (kortnummer % 13 == 0) vaerdig = "Konge";
                    else if (kortnummer % 13 == 12 ) vaerdig = "Dame";
                    else if (kortnummer % 13 == 11 ) vaerdig = "knægt";
                    else if (kortnummer % 13 == 1 ) vaerdig = "Es";
                    else vaerdig = (kortnummer % 13).ToString();
                }
                resultat = $"{vaerdig}-{farve}.jpg";
            return resultat;
        }
    }
}     