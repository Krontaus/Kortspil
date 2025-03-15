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
            if (!int.TryParse(Kort.Text, out _))
            {
                MessageBox.Show("Du skal indtaste et tal fra 1-52"); // undersøger om der er indtastet et tal
                return;
            }
            int kortnummer = Convert.ToInt32(Kort.Text);
            string filnavn = FindBillede(kortnummer);
            string url = $"/Billeder/{filnavn}";
            Uri uri = new (url, UriKind.Relative);
            BitmapImage image = new(uri);
           
            Billede.Source = image;
            
        }

        private string FindBillede(int kortnummer)
        {
            string resultat = "";
                if (kortnummer < 1 || kortnummer > 52) // undersøger om kortnummeret er indenfor intervallet
                {
                    MessageBox.Show("Kortnummeret skal være mellem 1 og 52");
                    resultat = "Purple_back.jpg";
                }
                else
                {
                    if (kortnummer == 1) resultat = "Es-Spar.jpg";
                    else if (kortnummer == 2) resultat = "2-Spar.jpg";
                    else if (kortnummer == 3) resultat = "3-Spar.jpg";
                    else if (kortnummer == 4) resultat = "4-Spar.jpg";
                    else if (kortnummer == 5) resultat = "5-Spar.jpg";
                    else if (kortnummer == 6) resultat = "6-Spar.jpg";
                    else if (kortnummer == 7) resultat = "7-Spar.jpg";
                    else if (kortnummer == 8) resultat = "8-Spar.jpg";
                    else if (kortnummer == 9) resultat = "9-Spar.jpg";
                    else if (kortnummer == 10) resultat = "10-Spar.jpg";
                    else if (kortnummer == 11) resultat = "Knægt-Spar.jpg";
                    else if (kortnummer == 12) resultat = "Dame-Spar.jpg";
                    else if (kortnummer == 13) resultat = "Konge-Spar.jpg";
                    else if (kortnummer == 14) resultat = "Es-Ruder.jpg";
                    else if (kortnummer == 15) resultat = "2-Ruder.jpg";
                    else if (kortnummer == 16) resultat = "3-Ruder.jpg";
                    else if (kortnummer == 17) resultat = "4-Ruder.jpg";
                    else if (kortnummer == 18) resultat = "5-Ruder.jpg";
                    else if (kortnummer == 19) resultat = "6-Ruder.jpg";
                    else if (kortnummer == 20) resultat = "7-Ruder.jpg";
                    else if (kortnummer == 21) resultat = "8-Ruder.jpg";
                    else if (kortnummer == 22) resultat = "9-Ruder.jpg";
                    else if (kortnummer == 23) resultat = "10-Ruder.jpg";
                    else if (kortnummer == 24) resultat = "Knægt-Ruder.jpg";
                    else if (kortnummer == 25) resultat = "Dame-Ruder.jpg";
                    else if (kortnummer == 26) resultat = "Konge-Ruder.jpg";
                    else if (kortnummer == 27) resultat = "Es-Klør.jpg";
                    else if (kortnummer == 28) resultat = "2-Klør.jpg";
                    else if (kortnummer == 29) resultat = "3-Klør.jpg";
                    else if (kortnummer == 30) resultat = "4-Klør.jpg";
                    else if (kortnummer == 31) resultat = "5-Klør.jpg";
                    else if (kortnummer == 32) resultat = "6-Klør.jpg";
                    else if (kortnummer == 33) resultat = "7-Klør.jpg";
                    else if (kortnummer == 34) resultat = "8-Klør.jpg";
                    else if (kortnummer == 35) resultat = "9-Klør.jpg";
                    else if (kortnummer == 36) resultat = "10-Klør.jpg";
                    else if (kortnummer == 37) resultat = "Knægt-Klør.jpg";
                    else if (kortnummer == 38) resultat = "Dame-Klør.jpg";
                    else if (kortnummer == 39) resultat = "Konge-Klør.jpg";
                    else if (kortnummer == 40) resultat = "Es-Hjerter.jpg";
                    else if (kortnummer == 41) resultat = "2-Hjerter.jpg";
                    else if (kortnummer == 42) resultat = "3-Hjerter.jpg";
                    else if (kortnummer == 43) resultat = "4-Hjerter.jpg";
                    else if (kortnummer == 44) resultat = "5-Hjerter.jpg";
                    else if (kortnummer == 45) resultat = "6-Hjerter.jpg";
                    else if (kortnummer == 46) resultat = "7-Hjerter.jpg";
                    else if (kortnummer == 47) resultat = "8-Hjerter.jpg";
                    else if (kortnummer == 48) resultat = "9-Hjerter.jpg";
                    else if (kortnummer == 49) resultat = "10-Hjerter.jpg";
                    else if (kortnummer == 50) resultat = "Knægt-Hjerter.jpg";
                    else if (kortnummer == 51) resultat = "Dame-Hjerter.jpg";
                    else if (kortnummer == 52) resultat = "Konge-Hjerter.jpg";
                }
            return resultat;
        }
    }
}
