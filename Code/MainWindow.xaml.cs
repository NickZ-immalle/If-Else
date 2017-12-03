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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password;
            Label.Content = "";
            password = TextBox.Text;

            if (password == "password")
            {
                Label.Content = "Correct";
            }
            else
            {
                Label.Content = "Wrong";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int nog = Convert.ToInt32(TextBox2.Text);
            switch (nog)
            {
                case 1:
                    Button2.Content = "Je getal was 1";
                    break;
                case 2:
                    Button2.Content = "Je getal was 2";
                    break;
                default:
                    Button2.Content = "je getal was 3";
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime verjaardag = new DateTime(2018, 9, 11);
            DateTime geboorte = new DateTime(2001, 9, 11);
            TimeSpan leeftijd;
            leeftijd = verjaardag - geboorte;
            Label2.Content = leeftijd;
        }
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Label3.Background = new SolidColorBrush(Colors.GhostWhite);
        }
    }
}
